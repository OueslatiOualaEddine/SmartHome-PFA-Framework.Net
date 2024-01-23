namespace Smart_Home
{
    partial class Connexion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numerocin = new System.Windows.Forms.TextBox();
            this.adressemail = new System.Windows.Forms.TextBox();
            this.motsdepasse = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.Createaccount = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(160, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(606, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to your Account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cin
            // 
            this.cin.AutoSize = true;
            this.cin.BackColor = System.Drawing.Color.Transparent;
            this.cin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cin.Location = new System.Drawing.Point(134, 189);
            this.cin.Name = "cin";
            this.cin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cin.Size = new System.Drawing.Size(124, 36);
            this.cin.TabIndex = 1;
            this.cin.Text = "N° CIN :";
            this.cin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(134, 289);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(222, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adresse Email :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(134, 392);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(227, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mots de Passe :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numerocin
            // 
            this.numerocin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerocin.Location = new System.Drawing.Point(289, 189);
            this.numerocin.Name = "numerocin";
            this.numerocin.Size = new System.Drawing.Size(383, 38);
            this.numerocin.TabIndex = 4;
            this.numerocin.Text = "ex: 09523642";
            this.numerocin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numerocin.TextChanged += new System.EventHandler(this.numerocin_TextChanged);
            // 
            // adressemail
            // 
            this.adressemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressemail.Location = new System.Drawing.Point(381, 289);
            this.adressemail.Name = "adressemail";
            this.adressemail.Size = new System.Drawing.Size(462, 38);
            this.adressemail.TabIndex = 5;
            this.adressemail.Text = "nom.prenom@esen.tn";
            this.adressemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // motsdepasse
            // 
            this.motsdepasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motsdepasse.Location = new System.Drawing.Point(404, 390);
            this.motsdepasse.Name = "motsdepasse";
            this.motsdepasse.Size = new System.Drawing.Size(395, 38);
            this.motsdepasse.TabIndex = 6;
            this.motsdepasse.Text = "¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤";
            this.motsdepasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.PaleGreen;
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submit.Location = new System.Drawing.Point(247, 503);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(211, 50);
            this.submit.TabIndex = 7;
            this.submit.Text = "Connecter";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Tomato;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reset.Location = new System.Drawing.Point(494, 503);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(211, 50);
            this.reset.TabIndex = 8;
            this.reset.Text = "Effacer";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Createaccount
            // 
            this.Createaccount.AutoSize = true;
            this.Createaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createaccount.Location = new System.Drawing.Point(320, 661);
            this.Createaccount.Name = "Createaccount";
            this.Createaccount.Size = new System.Drawing.Size(347, 29);
            this.Createaccount.TabIndex = 9;
            this.Createaccount.TabStop = true;
            this.Createaccount.Text = "Créer votre Compte Maintenant";
            this.Createaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Createaccount_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nouveau ?  Vous n\'avez pas de compte ?";
            // 
            // Connexion
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_Home.Properties.Resources.background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.reset;
            this.ClientSize = new System.Drawing.Size(962, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Createaccount);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.motsdepasse);
            this.Controls.Add(this.adressemail);
            this.Controls.Add(this.numerocin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.Text = "Se Connecter";
            this.Load += new System.EventHandler(this.label1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numerocin;
        private System.Windows.Forms.TextBox adressemail;
        private System.Windows.Forms.TextBox motsdepasse;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.LinkLabel Createaccount;
        private System.Windows.Forms.Label label4;
    }
}