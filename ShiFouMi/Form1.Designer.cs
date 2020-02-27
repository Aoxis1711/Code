namespace ShiFouMi
{
    partial class JeuChiFouMi
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
            this.label2 = new System.Windows.Forms.Label();
            this.LblScoreJoueur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblScoreOrdi = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.EmojiOrdi = new System.Windows.Forms.PictureBox();
            this.EmojiJoueur = new System.Windows.Forms.PictureBox();
            this.CadreJeuOrdi = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CadreJeu1 = new System.Windows.Forms.PictureBox();
            this.Puit = new System.Windows.Forms.PictureBox();
            this.Feuille = new System.Windows.Forms.PictureBox();
            this.Ciseau = new System.Windows.Forms.PictureBox();
            this.Pierre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmojiOrdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmojiJoueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadreJeuOrdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadreJeu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Puit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Feuille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ciseau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pierre)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(189, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Joueur";
            // 
            // LblScoreJoueur
            // 
            this.LblScoreJoueur.AutoSize = true;
            this.LblScoreJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblScoreJoueur.Location = new System.Drawing.Point(236, 98);
            this.LblScoreJoueur.Name = "LblScoreJoueur";
            this.LblScoreJoueur.Size = new System.Drawing.Size(26, 29);
            this.LblScoreJoueur.TabIndex = 5;
            this.LblScoreJoueur.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(692, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ordinateur";
            // 
            // LblScoreOrdi
            // 
            this.LblScoreOrdi.AutoSize = true;
            this.LblScoreOrdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblScoreOrdi.Location = new System.Drawing.Point(764, 98);
            this.LblScoreOrdi.Name = "LblScoreOrdi";
            this.LblScoreOrdi.Size = new System.Drawing.Size(26, 29);
            this.LblScoreOrdi.TabIndex = 7;
            this.LblScoreOrdi.Text = "0";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Start.Location = new System.Drawing.Point(400, 709);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(209, 55);
            this.Start.TabIndex = 14;
            this.Start.Text = "Nouvelle Partie";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // EmojiOrdi
            // 
            this.EmojiOrdi.Location = new System.Drawing.Point(911, 61);
            this.EmojiOrdi.Name = "EmojiOrdi";
            this.EmojiOrdi.Size = new System.Drawing.Size(115, 114);
            this.EmojiOrdi.TabIndex = 9;
            this.EmojiOrdi.TabStop = false;
            // 
            // EmojiJoueur
            // 
            this.EmojiJoueur.Location = new System.Drawing.Point(12, 61);
            this.EmojiJoueur.Name = "EmojiJoueur";
            this.EmojiJoueur.Size = new System.Drawing.Size(115, 114);
            this.EmojiJoueur.TabIndex = 8;
            this.EmojiJoueur.TabStop = false;
            // 
            // CadreJeuOrdi
            // 
            this.CadreJeuOrdi.BackgroundImage = global::ShiFouMi.Properties.Resources.fond;
            this.CadreJeuOrdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CadreJeuOrdi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CadreJeuOrdi.Location = new System.Drawing.Point(678, 157);
            this.CadreJeuOrdi.Name = "CadreJeuOrdi";
            this.CadreJeuOrdi.Size = new System.Drawing.Size(209, 200);
            this.CadreJeuOrdi.TabIndex = 3;
            this.CadreJeuOrdi.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ShiFouMi.Properties.Resources.schema;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(400, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 200);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CadreJeu1
            // 
            this.CadreJeu1.BackgroundImage = global::ShiFouMi.Properties.Resources.fond;
            this.CadreJeu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CadreJeu1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CadreJeu1.Location = new System.Drawing.Point(146, 157);
            this.CadreJeu1.Name = "CadreJeu1";
            this.CadreJeu1.Size = new System.Drawing.Size(209, 200);
            this.CadreJeu1.TabIndex = 1;
            this.CadreJeu1.TabStop = false;
            // 
            // Puit
            // 
            this.Puit.BackgroundImage = global::ShiFouMi.Properties.Resources.puits;
            this.Puit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Puit.Location = new System.Drawing.Point(798, 462);
            this.Puit.Name = "Puit";
            this.Puit.Size = new System.Drawing.Size(163, 163);
            this.Puit.TabIndex = 13;
            this.Puit.TabStop = false;
            this.Puit.Tag = "4";
            this.Puit.Visible = false;
            this.Puit.Click += new System.EventHandler(this.Puit_Click);
            // 
            // Feuille
            // 
            this.Feuille.BackgroundImage = global::ShiFouMi.Properties.Resources.feuille;
            this.Feuille.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Feuille.Location = new System.Drawing.Point(567, 462);
            this.Feuille.Name = "Feuille";
            this.Feuille.Size = new System.Drawing.Size(163, 163);
            this.Feuille.TabIndex = 12;
            this.Feuille.TabStop = false;
            this.Feuille.Tag = "3";
            this.Feuille.Visible = false;
            this.Feuille.Click += new System.EventHandler(this.Feuille_Click);
            // 
            // Ciseau
            // 
            this.Ciseau.BackgroundImage = global::ShiFouMi.Properties.Resources.ciseau;
            this.Ciseau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ciseau.Location = new System.Drawing.Point(332, 462);
            this.Ciseau.Name = "Ciseau";
            this.Ciseau.Size = new System.Drawing.Size(163, 163);
            this.Ciseau.TabIndex = 11;
            this.Ciseau.TabStop = false;
            this.Ciseau.Tag = "2";
            this.Ciseau.Visible = false;
            this.Ciseau.Click += new System.EventHandler(this.Ciseau_Click);
            // 
            // Pierre
            // 
            this.Pierre.BackgroundImage = global::ShiFouMi.Properties.Resources.pierre;
            this.Pierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pierre.Location = new System.Drawing.Point(99, 462);
            this.Pierre.Name = "Pierre";
            this.Pierre.Size = new System.Drawing.Size(163, 163);
            this.Pierre.TabIndex = 10;
            this.Pierre.TabStop = false;
            this.Pierre.Tag = "1";
            this.Pierre.Visible = false;
            this.Pierre.Click += new System.EventHandler(this.Pierre_Click);
            // 
            // JeuChiFouMi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 776);
            this.Controls.Add(this.Puit);
            this.Controls.Add(this.Feuille);
            this.Controls.Add(this.Ciseau);
            this.Controls.Add(this.Pierre);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.EmojiOrdi);
            this.Controls.Add(this.EmojiJoueur);
            this.Controls.Add(this.LblScoreOrdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblScoreJoueur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CadreJeuOrdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CadreJeu1);
            this.Name = "JeuChiFouMi";
            this.Text = "ChiFouMi";
            ((System.ComponentModel.ISupportInitialize)(this.EmojiOrdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmojiJoueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadreJeuOrdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CadreJeu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Puit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Feuille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ciseau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pierre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CadreJeu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CadreJeuOrdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblScoreJoueur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblScoreOrdi;
        private System.Windows.Forms.PictureBox EmojiJoueur;
        private System.Windows.Forms.PictureBox EmojiOrdi;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox Puit;
        private System.Windows.Forms.PictureBox Feuille;
        private System.Windows.Forms.PictureBox Ciseau;
        private System.Windows.Forms.PictureBox Pierre;
    }
}

