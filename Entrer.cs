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
   /* MySqlConnection cn = new MySqlConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\Administrator\\Documents\\Comptoir.mdb");*/

    public partial class Entrer : Form
    {
        public Entrer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile c = new Profile();
            c.Show();

        }
    }
}
