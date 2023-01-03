using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace basketbolFinal
{
    public partial class haberler : Form
    {
        anaSayfa main;
        public haberler(anaSayfa anaSayfa)
        {
            InitializeComponent();
            main = anaSayfa;
        }

        private void haberler_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
        }
    }
}
