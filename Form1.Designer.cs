namespace _2048_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 63.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(130, 10);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(246, 98);
            this.Title.TabIndex = 0;
            this.Title.Text = "2048";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(382, 22);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(147, 43);
            this.ScoreText.TabIndex = 1;
            this.ScoreText.Text = "Score :";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(382, 57);
            this.Score.Margin = new System.Windows.Forms.Padding(0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(41, 43);
            this.Score.TabIndex = 2;
            this.Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 602);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label Score;
    }
}

