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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.pnlQuitter = new System.Windows.Forms.Panel();
            this.pnlWin = new System.Windows.Forms.Panel();
            this.pnlLose = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuitterLose = new ePOSOne.btnProduct.Button_WOC();
            this.btnContinue = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.btnQuitter = new ePOSOne.btnProduct.Button_WOC();
            this.pnlQuitter.SuspendLayout();
            this.pnlWin.SuspendLayout();
            this.pnlLose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.ScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
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
            this.Score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Score.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(382, 57);
            this.Score.Margin = new System.Windows.Forms.Padding(0);
            this.Score.MinimumSize = new System.Drawing.Size(147, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(147, 43);
            this.Score.TabIndex = 2;
            this.Score.Text = "0";
            // 
            // pnlQuitter
            // 
            this.pnlQuitter.Controls.Add(this.btnQuitter);
            this.pnlQuitter.Location = new System.Drawing.Point(281, 569);
            this.pnlQuitter.Name = "pnlQuitter";
            this.pnlQuitter.Size = new System.Drawing.Size(125, 55);
            this.pnlQuitter.TabIndex = 3;
            // 
            // pnlWin
            // 
            this.pnlWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(180)))));
            this.pnlWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWin.Controls.Add(this.pictureBox2);
            this.pnlWin.Controls.Add(this.btnContinue);
            this.pnlWin.Controls.Add(this.button_WOC1);
            this.pnlWin.Controls.Add(this.label1);
            this.pnlWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlWin.Location = new System.Drawing.Point(81, 211);
            this.pnlWin.Name = "pnlWin";
            this.pnlWin.Size = new System.Drawing.Size(537, 239);
            this.pnlWin.TabIndex = 4;
            this.pnlWin.Visible = false;
            // 
            // pnlLose
            // 
            this.pnlLose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(180)))));
            this.pnlLose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLose.Controls.Add(this.label3);
            this.pnlLose.Controls.Add(this.pictureBox1);
            this.pnlLose.Controls.Add(this.btnQuitterLose);
            this.pnlLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLose.Location = new System.Drawing.Point(81, 211);
            this.pnlLose.Name = "pnlLose";
            this.pnlLose.Size = new System.Drawing.Size(537, 239);
            this.pnlLose.TabIndex = 5;
            this.pnlLose.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLose_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 59);
            this.label3.MaximumSize = new System.Drawing.Size(400, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tu as perdu ;(";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-9, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 74);
            this.label1.MaximumSize = new System.Drawing.Size(400, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tu as gagné !!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuitterLose
            // 
            this.btnQuitterLose.BorderColor = System.Drawing.Color.IndianRed;
            this.btnQuitterLose.ButtonColor = System.Drawing.Color.Salmon;
            this.btnQuitterLose.FlatAppearance.BorderSize = 0;
            this.btnQuitterLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitterLose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitterLose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuitterLose.Location = new System.Drawing.Point(252, 160);
            this.btnQuitterLose.Name = "btnQuitterLose";
            this.btnQuitterLose.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.btnQuitterLose.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.btnQuitterLose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuitterLose.Size = new System.Drawing.Size(125, 45);
            this.btnQuitterLose.TabIndex = 1;
            this.btnQuitterLose.TabStop = false;
            this.btnQuitterLose.Text = "Quitter";
            this.btnQuitterLose.TextColor = System.Drawing.Color.White;
            this.btnQuitterLose.UseVisualStyleBackColor = true;
            this.btnQuitterLose.Click += new System.EventHandler(this.btnQuitterLose_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BorderColor = System.Drawing.Color.IndianRed;
            this.btnContinue.ButtonColor = System.Drawing.Color.Salmon;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinue.Location = new System.Drawing.Point(89, 177);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.btnContinue.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.btnContinue.OnHoverTextColor = System.Drawing.Color.White;
            this.btnContinue.Size = new System.Drawing.Size(125, 45);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "Continuer";
            this.btnContinue.TextColor = System.Drawing.Color.White;
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.IndianRed;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Salmon;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_WOC1.Location = new System.Drawing.Point(326, 177);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(125, 45);
            this.button_WOC1.TabIndex = 1;
            this.button_WOC1.TabStop = false;
            this.button_WOC1.Text = "Quitter";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click_1);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BorderColor = System.Drawing.Color.IndianRed;
            this.btnQuitter.ButtonColor = System.Drawing.Color.Salmon;
            this.btnQuitter.FlatAppearance.BorderSize = 0;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuitter.Location = new System.Drawing.Point(0, 0);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.OnHoverBorderColor = System.Drawing.Color.IndianRed;
            this.btnQuitter.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.btnQuitter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQuitter.Size = new System.Drawing.Size(125, 45);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.TabStop = false;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextColor = System.Drawing.Color.White;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(675, 636);
            this.Controls.Add(this.pnlLose);
            this.Controls.Add(this.pnlWin);
            this.Controls.Add(this.pnlQuitter);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "2048";
            this.pnlQuitter.ResumeLayout(false);
            this.pnlWin.ResumeLayout(false);
            this.pnlWin.PerformLayout();
            this.pnlLose.ResumeLayout(false);
            this.pnlLose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label Score;
        private ePOSOne.btnProduct.Button_WOC btnQuitter;
        private System.Windows.Forms.Panel pnlQuitter;
        private System.Windows.Forms.Panel pnlWin;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC btnContinue;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.Panel pnlLose;
        private ePOSOne.btnProduct.Button_WOC btnQuitterLose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

