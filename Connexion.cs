using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Smart_Home
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numerocin_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            numerocin.Clear();
            adressemail.Clear();
            motsdepasse.Clear();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            /*
            if (numerocin.Text == "")
                MessageBox.Show("Champ N° CIN est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (adressemail.Text == "")
                MessageBox.Show("Champ Adresse Email est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (motsdepasse.Text == "")
                MessageBox.Show("Champ Mots de Passe est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int x;
                if (!int.TryParse(numerocin.Text, out x))
                {
                    MessageBox.Show("saisir un entier N°CIN ", "Erreur de type", MessageBoxButtons.OK);
                    numerocin.Text = "";
                }

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;
                cmd.CommandText = "select * from client where cin='" + x + "'";
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                    p = true;

                dr.Close();

            }


            */

            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void Createaccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Creation cr = new Creation();
            cr.Show();
            this.Close();

        }
    }
}
