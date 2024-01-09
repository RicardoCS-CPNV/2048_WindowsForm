using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_WindowsForm
{
    public partial class Form1 : Form
    {
        static Label[,] labels = new Label[4, 4]; //Création du tableau de labels
        static int[,] table = new int[4, 4]; //Création du tableau ud jeu
        static Color[] color = { Color.Snow, Color.Beige, Color.MistyRose, Color.SandyBrown, Color.Orange, Color.Tomato, };
        static int score = 0;
        bool Defaite = false;
        public Form1()
        {
            InitializeComponent();
            InitJeu();
        }

        public void InitJeu()
        {
            for (int ligne = 0; ligne < table.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < table.GetLength(0); colonne++)
                {
                    labels[ligne, colonne] = new Label(); //Création du tableau

                    //Le 20 + 100 * colonne détermine le placement du premier label
                    //Le 20 + 100 * ligne détermine le placement du label en Y
                    //Le 90, 90 est la taille du label
                    labels[ligne, colonne].Bounds = new Rectangle(130 + 110 * colonne, 120 + 110 * ligne, 100, 100);

                    //Met le texte au centre du label
                    labels[ligne, colonne].TextAlign = ContentAlignment.MiddleCenter;
                    labels[ligne, colonne].Font = new Font("Arial", 20, FontStyle.Bold);

                    Controls.Add(labels[ligne, colonne]);
                }
            }
            //Génlration des 2 nombres aléatoires
            for (int i = 0; i < 2; i++)
            {
                NombreAleatoire();
                affiche();
            }
            while (true)
            {
                //Tant que les conditions sont remplies, l'utilisateur reste dans la boucle if
                if (!Defaite)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == Keys.Left ||
                        keyInfo.Key == ConsoleKey.UpArrow ||
                        keyInfo.Key == ConsoleKey.RightArrow ||
                        keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        bool tableChange = DetectionFleche(keyInfo.Key);
                        if (tableChange)
                        {
                            NombreAleatoire();
                        }

                        Console.Clear();
                        affiche();

                        if (Victoire())
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            MessageBox.Show("\nTu as gagné, tu peux continuer à jouer !!!");
                        }
                        else if (!TableauRempli())
                        {
                            Console.Clear();
                            affiche();
                            Console.ForegroundColor = ConsoleColor.Red;
                            MessageBox.Show("Game Lost");
                            Defaite = true;
                        }
                    }
                    else if (keyInfo.Key == ConsoleKey.C)
                    {
                        return; //Quitte le programme
                    }
                    else
                    {
                        MessageBox.Show("Veuillez taper une touche valide.");
                    }
                }
                else //L'utilisateur vient de perdre la partie
                {
                    affiche();
                    MessageBox.Show("\nVous avez perdu. Appuyez sur 'C' pour quitter.");
                }

            }

            void affiche()
            {
                for (int ligne = 0; ligne < table.GetLength(0); ligne++)
                {
                    for (int colonne = 0; colonne < table.GetLength(0); colonne++)
                    {
                        if (table[ligne, colonne] > 0)
                        {
                            labels[ligne, colonne].Text = table[ligne, colonne].ToString();
                        }
                        else
                        {
                            labels[ligne, colonne].Text = "";
                        }
                        labels[ligne, colonne].BackColor = color[table[ligne, colonne]];
                    }
                }
            }

            //Créer un nombre aléatoire et selectionne une tuile aléatoire
            void NombreAleatoire()
            {
                Random random = new Random();
                int randomNumber2 = (random.Next(10) == 0) ? 4 : 2;

                if (!AjoutNombrePossible())
                {
                    return;
                }

                bool caseVide = false;
                while (!caseVide)
                {
                    int randomLine = random.Next(0, 4);
                    int randomLine2 = random.Next(0, 4);

                    if (table[randomLine, randomLine2] == 0)
                    {
                        table[randomLine, randomLine2] = randomNumber2;
                        caseVide = true;
                    }
                }
            }

            //Regarde si la valeur est de 0
            bool AjoutNombrePossible()
            {
                for (int row = 0; row < table.GetLength(0); row++)
                {
                    for (int col = 0; col < table.GetLength(1); col++)
                    {
                        if (table[row, col] == 0)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }


            /*public void newVide()
            {
                //Génération d'un tableau des cases vides, de 0 à 16
                List<int> aVide = new List<int>();
                for (int ligne = 0; ligne < table.GetLength(0); ligne++)
                {
                    for (int colonne = 0; colonne < table.GetLength(0); colonne++)
                    {
                        if (table[ligne, colonne] == 0)
                        {
                            aVide.Add(4 * ligne + colonne); //Stocker le num de case
                        }
                    }
                }

                //Prendre une de ces cases aléatoirement
                if (aVide.Count > 0)
                {
                    Random aleatoire = new Random();
                    int nalea = aleatoire.Next(aVide.Count); //Génère un entier aléatoire
                    table[aVide[nalea] / 4, aVide[nalea] % 4] = 1; //Met un 2 (2 puissamce 1) dans la case choisie
                    affiche();
                }

            }*/

            //Détection des flèches
            bool DetectionFleche(ConsoleKey key)
            {
                int[,] tableTest = (int[,])table.Clone(); //Créer une copie du tableau avant de faire le mouvement
                int[] table1D;
                switch (key)
                {
                    //Flêche du haut
                    case ConsoleKey.UpArrow:
                        for (int i = 0; i < 4; i++)
                        {
                            table1D = MouvementFusion(table[0, i], table[1, i], table[2, i], table[3, i]);
                            table[0, i] = table1D[0];
                            table[1, i] = table1D[1];
                            table[2, i] = table1D[2];
                            table[3, i] = table1D[3];
                        }
                        affiche();
                        break;

                    //Flêche du bas
                    case ConsoleKey.DownArrow:
                        for (int i = 0; i < 4; i++)
                        {
                            table1D = MouvementFusion(table[3, i], table[2, i], table[1, i], table[0, i]);
                            table[0, i] = table1D[3];
                            table[1, i] = table1D[2];
                            table[2, i] = table1D[1];
                            table[3, i] = table1D[0];
                        }
                        affiche();
                        break;

                    //Flêche de gauche
                    case ConsoleKey.LeftArrow:
                        for (int i = 0; i < 4; i++)
                        {
                            table1D = MouvementFusion(table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
                            table[i, 0] = table1D[0];
                            table[i, 1] = table1D[1];
                            table[i, 2] = table1D[2];
                            table[i, 3] = table1D[3];
                        }
                        affiche();
                        break;

                    //Flêche de droite
                    case ConsoleKey.RightArrow:
                        for (int i = 0; i < 4; i++)
                        {
                            table1D = MouvementFusion(table[i, 3], table[i, 2], table[i, 1], table[i, 0]);
                            table[i, 0] = table1D[3];
                            table[i, 1] = table1D[2];
                            table[i, 2] = table1D[1];
                            table[i, 3] = table1D[0];
                        }
                        affiche();
                        break;

                    //C quitte le programme
                    case ConsoleKey.C:
                        break;

                    //Affiche un message d'erreur et demande d'appuyer sur une flêche
                    default:
                        Console.WriteLine("Veuillez taper une touche valide.");
                        break;
                }
                return ChangementTable(tableTest, table); //Verifie si le tableau a été modifié après le mouvement
            }

            //Gère le mouvement et la fusion des tuiles
            int[] MouvementFusion(int nb0, int nb1, int nb2, int nb3)
            {
                //Gère le mouvement
                if (nb2 == 0 && nb3 > 0)
                {
                    nb2 = nb3;
                    nb3 = 0;
                }
                if (nb1 == 0 && nb2 > 0)
                {
                    nb1 = nb2;
                    nb2 = nb3;
                    nb3 = 0;
                }
                if (nb0 == 0 && nb1 > 0)
                {
                    nb0 = nb1;
                    nb1 = nb2;
                    nb2 = nb3;
                    nb3 = 0;
                }
                //Gère la fusion
                if (nb0 == nb1)
                {
                    nb0 += nb1;
                    nb1 = nb2;
                    nb2 = nb3;
                    nb3 = 0;
                    score += nb0;
                }
                if (nb1 == nb2)
                {
                    nb1 += nb2;
                    nb2 = nb3;
                    nb3 = 0;
                    score += nb1;
                }
                if (nb2 == nb3)
                {
                    nb2 += nb3;
                    nb3 = 0;
                    score += nb2;
                }
                int[] tableau = { nb0, nb1, nb2, nb3 };
                return tableau;
            }

            //Verifie si le tableau est remplie et si des mouvements sont encores possible
            bool TableauRempli()
            {
                for (int row = 0; row < table.GetLength(0); row++)
                {
                    for (int col = 0; col < table.GetLength(1); col++)
                    {
                        if (table[row, col] == 0)
                            return true; //Trouve un 0 dans le tableau

                        if (row < table.GetLength(0) - 1 && table[row, col] == table[row + 1, col])
                            return true; //Mouvement Verticale possible

                        if (col < table.GetLength(1) - 1 && table[row, col] == table[row, col + 1])
                            return true; //M ouvement Horizontale possible
                    }
                }

                return false;
            }

            //Verifie si le tableau est identique ou non
            bool ChangementTable(int[,] tableOriginal, int[,] tableCourante)
            {
                for (int row = 0; row < tableOriginal.GetLength(0); row++)
                {
                    for (int col = 0; col < tableOriginal.GetLength(1); col++)
                    {
                        if (tableOriginal[row, col] != tableCourante[row, col])
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            //Verifie la victoire
            bool Victoire()
            {
                for (int row = 0; row < table.GetLength(0); row++)
                {
                    for (int col = 0; col < table.GetLength(1); col++)
                    {
                        if (table[row, col] >= 2048)
                            return true;
                    }
                }
                return false;
            }



        }
    }
}
