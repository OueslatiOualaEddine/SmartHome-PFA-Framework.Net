namespace Smart_Home
{
    partial class Creation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titre = new System.Windows.Forms.Label();
            this.InfoPersonelle = new System.Windows.Forms.GroupBox();
            this.numtel = new System.Windows.Forms.TextBox();
            this.datedenaissance = new System.Windows.Forms.DateTimePicker();
            this.genre = new System.Windows.Forms.ComboBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.motsdepasse = new System.Windows.Forms.TextBox();
            this.adressemail = new System.Windows.Forms.TextBox();
            this.numcin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.InfoPersonelle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.Transparent;
            this.titre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titre.Location = new System.Drawing.Point(185, 25);
            this.titre.Name = "titre";
            this.titre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titre.Size = new System.Drawing.Size(573, 69);
            this.titre.TabIndex = 1;
            this.titre.Text = "Create your Account";
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titre.Click += new System.EventHandler(this.label1_Click);
            // 
            // InfoPersonelle
            // 
            this.InfoPersonelle.BackColor = System.Drawing.Color.Thistle;
            this.InfoPersonelle.Controls.Add(this.numtel);
            this.InfoPersonelle.Controls.Add(this.datedenaissance);
            this.InfoPersonelle.Controls.Add(this.genre);
            this.InfoPersonelle.Controls.Add(this.prenom);
            this.InfoPersonelle.Controls.Add(this.nom);
            this.InfoPersonelle.Controls.Add(this.label5);
            this.InfoPersonelle.Controls.Add(this.label4);
            this.InfoPersonelle.Controls.Add(this.label3);
            this.InfoPersonelle.Controls.Add(this.label2);
            this.InfoPersonelle.Controls.Add(this.label1);
            this.InfoPersonelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPersonelle.Location = new System.Drawing.Point(38, 153);
            this.InfoPersonelle.Name = "InfoPersonelle";
            this.InfoPersonelle.Size = new System.Drawing.Size(441, 569);
            this.InfoPersonelle.TabIndex = 2;
            this.InfoPersonelle.TabStop = false;
            this.InfoPersonelle.Text = "Information Personnelle";
            // 
            // numtel
            // 
            this.numtel.Location = new System.Drawing.Point(179, 476);
            this.numtel.Name = "numtel";
            this.numtel.Size = new System.Drawing.Size(237, 38);
            this.numtel.TabIndex = 9;
            this.numtel.Text = "ex: 22355372";
            this.numtel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datedenaissance
            // 
            this.datedenaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedenaissance.Location = new System.Drawing.Point(127, 394);
            this.datedenaissance.MaxDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.datedenaissance.MinDate = new System.DateTime(1995, 12, 31, 0, 0, 0, 0);
            this.datedenaissance.Name = "datedenaissance";
            this.datedenaissance.Size = new System.Drawing.Size(186, 38);
            this.datedenaissance.TabIndex = 8;
            this.datedenaissance.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Items.AddRange(new object[] {
            "Male",
            "Femelle"});
            this.genre.Location = new System.Drawing.Point(138, 239);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(134, 37);
            this.genre.TabIndex = 7;
            this.genre.Text = "    Genre";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(159, 146);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(257, 38);
            this.prenom.TabIndex = 6;
            this.prenom.Text = "Votre Prenom";
            this.prenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(127, 58);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(289, 38);
            this.nom.TabIndex = 5;
            this.nom.Text = "Votre Nom";
            this.nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "N° de Tel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de Naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.motsdepasse);
            this.groupBox1.Controls.Add(this.adressemail);
            this.groupBox1.Controls.Add(this.numcin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(501, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 391);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authentification";
            // 
            // motsdepasse
            // 
            this.motsdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motsdepasse.Location = new System.Drawing.Point(100, 313);
            this.motsdepasse.Name = "motsdepasse";
            this.motsdepasse.Size = new System.Drawing.Size(295, 38);
            this.motsdepasse.TabIndex = 7;
            this.motsdepasse.Text = "¤¤¤¤¤¤¤¤¤¤¤¤¤";
            this.motsdepasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressemail
            // 
            this.adressemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressemail.Location = new System.Drawing.Point(79, 195);
            this.adressemail.Name = "adressemail";
            this.adressemail.Size = new System.Drawing.Size(316, 38);
            this.adressemail.TabIndex = 6;
            this.adressemail.Text = "nom.prenom@esen.tn";
            this.adressemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numcin
            // 
            this.numcin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcin.Location = new System.Drawing.Point(140, 58);
            this.numcin.Name = "numcin";
            this.numcin.Size = new System.Drawing.Size(255, 38);
            this.numcin.TabIndex = 5;
            this.numcin.Text = "ex: 09523642";
            this.numcin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mots de Passe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adresse Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "N° CIN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.PaleGreen;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(566, 591);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(303, 59);
            this.Create.TabIndex = 4;
            this.Create.Text = "Créer mon Compte";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Tomato;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(613, 656);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(215, 59);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "Effacer Tout";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_Home.Properties.Resources.background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 799);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoPersonelle);
            this.Controls.Add(this.titre);
            this.MaximizeBox = false;
            this.Name = "Creation";
            this.Text = "Creation";
            this.Load += new System.EventHandler(this.Creation_Load);
            this.InfoPersonelle.ResumeLayout(false);
            this.InfoPersonelle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.GroupBox InfoPersonelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DateTimePicker datedenaissance;
        private System.Windows.Forms.TextBox numcin;
        private System.Windows.Forms.TextBox adressemail;
        private System.Windows.Forms.TextBox motsdepasse;
        private System.Windows.Forms.TextBox numtel;
    }
}