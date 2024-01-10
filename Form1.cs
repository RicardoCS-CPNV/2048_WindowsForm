using ePOSOne.btnProduct;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _2048_WindowsForm
{
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Label[,] labels = new System.Windows.Forms.Label[4, 4];
        static int[,] table = new int[4, 4];
        static Color[] color = { Color.Snow, Color.AntiqueWhite, Color.NavajoWhite, Color.BurlyWood, Color.Goldenrod, Color.Chocolate, Color.SaddleBrown, Color.Brown, Color.AliceBlue, Color.LightGray, Color.Gray, Color.LightSlateGray, Color.DeepPink };
        static int score = 0;
        bool Defaite = false;
        static bool win = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox2.BackColor = Color.Transparent;

            pnlLose.Visible = false;
            InitJeu();
            this.KeyPreview = true;

            this.KeyDown += new KeyEventHandler((sender, e) =>
            {
                // Le contenu du gestionnaire d'événements KeyDown
                if (!Defaite)
                {
                    switch (e.KeyData)
                    {
                        case Keys.Left:
                        case Keys.Up:
                        case Keys.Right:
                        case Keys.Down:
                            bool tableChange = DetectionFleche(e.KeyData);
                            if (tableChange)
                            {
                                Score.Text = score.ToString();
                                NombreAleatoire();
                            }

                            Affiche();
                            Victoire();
                            if (!TableauRempli())
                            {
                                Defaite = true;
                            }
                            break;

                        case Keys.C:
                            Application.Exit();
                            break;
                    }
                }
                else
                {
                    pnlLose.Visible = true;
                    if (e.KeyData == Keys.C)
                    {
                        Application.Exit();
                    }
                }
            });
        }

        public void InitJeu()
        {
            for (int ligne = 0; ligne < table.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < table.GetLength(1); colonne++)
                {
                    labels[ligne, colonne] = new System.Windows.Forms.Label();
                    labels[ligne, colonne].Bounds = new Rectangle(130 + 110 * colonne, 120 + 110 * ligne, 100, 100);
                    labels[ligne, colonne].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    labels[ligne, colonne].Font = new Font("Arial Rounded MT Bold", 22, FontStyle.Bold);

                    Controls.Add(labels[ligne, colonne]);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                NombreAleatoire();
                Affiche();
            }
        }

        private void Affiche()
        {
            //réaffiche tout le tableau avec les bonnes couleurs et les bons textes, conformément au tableau jeu
            for (int ligne = 0; ligne < 4; ligne++)
            {
                for (int colonne = 0; colonne < 4; colonne++)
                {
                    if (table[ligne, colonne] > 0)
                        labels[ligne, colonne].Text = (table[ligne, colonne]).ToString();
                    else
                        labels[ligne, colonne].Text = "";
                    labels[ligne, colonne].BackColor = Couleur(table[ligne, colonne]);
                }
            }
        }

        private Color Couleur(int nombre)
        {
            int index = (int)Math.Log(nombre, 2);
            return index >= 0 && index < color.Length ? color[index] : Color.Snow;
        }

        private void NombreAleatoire()
        {
            Random random = new Random();
            int randomNumber2 = (random.Next(10) == 0) ? 4 : 1024;

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

        private bool AjoutNombrePossible()
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

        private bool DetectionFleche(Keys key)
        {
            int[,] tableTest = (int[,])table.Clone();
            int[] table1D;
            switch (key)
            {
                case Keys.Up:
                    for (int i = 0; i < 4; i++)
                    {
                        table1D = MouvementFusion(table[0, i], table[1, i], table[2, i], table[3, i]);
                        table[0, i] = table1D[0];
                        table[1, i] = table1D[1];
                        table[2, i] = table1D[2];
                        table[3, i] = table1D[3];
                    }
                    Affiche();
                    break;

                case Keys.Down:
                    for (int i = 0; i < 4; i++)
                    {
                        table1D = MouvementFusion(table[3, i], table[2, i], table[1, i], table[0, i]);
                        table[0, i] = table1D[3];
                        table[1, i] = table1D[2];
                        table[2, i] = table1D[1];
                        table[3, i] = table1D[0];
                    }
                    Affiche();
                    break;

                case Keys.Left:
                    for (int i = 0; i < 4; i++)
                    {
                        table1D = MouvementFusion(table[i, 0], table[i, 1], table[i, 2], table[i, 3]);
                        table[i, 0] = table1D[0];
                        table[i, 1] = table1D[1];
                        table[i, 2] = table1D[2];
                        table[i, 3] = table1D[3];
                    }
                    Affiche();
                    break;

                case Keys.Right:
                    for (int i = 0; i < 4; i++)
                    {
                        table1D = MouvementFusion(table[i, 3], table[i, 2], table[i, 1], table[i, 0]);
                        table[i, 0] = table1D[3];
                        table[i, 1] = table1D[2];
                        table[i, 2] = table1D[1];
                        table[i, 3] = table1D[0];
                    }
                    Affiche();
                    break;
            }
            return ChangementTable(tableTest, table);
        }

        private int[] MouvementFusion(int nb0, int nb1, int nb2, int nb3)
        {
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

        private bool TableauRempli()
        {
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    if (table[row, col] == 0)
                        return true;

                    if (row < table.GetLength(0) - 1 && table[row, col] == table[row + 1, col])
                        return true;

                    if (col < table.GetLength(1) - 1 && table[row, col] == table[row, col + 1])
                        return true;
                }
            }
            return false;
        }

        private bool ChangementTable(int[,] tableOriginal, int[,] tableCourante)
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

        private bool Victoire()
        {
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    if (table[row, col] == 2048 && win == false)
                    {
                        win = true;
                        pnlWin.Visible = true;
                    }
                }
            }
            return false;
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            pnlWin.Visible = false;
        }

        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuitterLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
