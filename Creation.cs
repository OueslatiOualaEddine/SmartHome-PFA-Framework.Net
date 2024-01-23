using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home
{
    public partial class Creation : Form
    {
        public Creation()
        {
            InitializeComponent();
        }

        private void Creation_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            nom.Clear();
            prenom.Clear();
            genre.SelectedIndex = -1;
            numtel.Clear();
            numcin.Clear();
            adressemail.Clear();
            motsdepasse.Clear();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (numcin.Text == "")
                MessageBox.Show("Champ N° CIN est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (adressemail.Text == "")
                MessageBox.Show("Champ Adresse Email est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (motsdepasse.Text == "")
                MessageBox.Show("Champ Mots de Passe est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (nom.Text == "")
                MessageBox.Show("Champ Mots de Passe est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (prenom.Text == "")
                MessageBox.Show("Champ Mots de Passe est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (genre.Text == "")
                MessageBox.Show("Champ Mots de Passe est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (datedenaissance.Text == "")
                MessageBox.Show("Champ Mots de Passe est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (numtel.Text == "")
                MessageBox.Show("Champ Adresse Email est vide!!", "champ vide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            

            Profile p = new Profile();
            p.Show();
            this.Close();
       

           
        }

    }

}