namespace Smart_Home
{
    partial class Profile
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
            this.Create = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Affichage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Affichage)).BeginInit();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.BackColor = System.Drawing.Color.Transparent;
            this.titre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titre.Location = new System.Drawing.Point(206, 34);
            this.titre.Name = "titre";
            this.titre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titre.Size = new System.Drawing.Size(542, 54);
            this.titre.TabIndex = 2;
            this.titre.Text = "Gestion de votre Compte";
            this.titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.SkyBlue;
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(682, 177);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(193, 59);
            this.Create.TabIndex = 5;
            this.Create.Text = "Modifier";
            this.Create.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(682, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(682, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.NavajoWhite;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(682, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 59);
            this.button3.TabIndex = 8;
            this.button3.Text = "Déconnecter";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Affichage
            // 
            this.Affichage.BackgroundColor = System.Drawing.SystemColors.Info;
            this.Affichage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Affichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Affichage.Location = new System.Drawing.Point(80, 137);
            this.Affichage.Name = "Affichage";
            this.Affichage.RowHeadersWidth = 51;
            this.Affichage.RowTemplate.Height = 24;
            this.Affichage.Size = new System.Drawing.Size(513, 417);
            this.Affichage.TabIndex = 9;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Smart_Home.Properties.Resources.background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 600);
            this.Controls.Add(this.Affichage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.titre);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Text = "Compte";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Affichage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Affichage;
    }
}