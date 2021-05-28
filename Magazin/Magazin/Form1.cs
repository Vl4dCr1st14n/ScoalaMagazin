using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin
{
    public partial class magazin : Form
    {
        public magazin()
        {
            InitializeComponent();
        }

        void See()
        {
            foreach (Control Label in this.Controls.OfType<Label>()) 
            {
                if(Label.Visible == false)
                   Label.Show();
            }

            foreach (Control PictureBox in this.Controls.OfType<PictureBox>())
            {
                if (PictureBox.Visible == false)
                    PictureBox.Show();
            }
        }

        private void picBx_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblGenres_Click(object sender, EventArgs e)
        {
            ///Nothing because I'm lazy :)
        }

        private void lblAdv_Click(object sender, EventArgs e)
        {
            See();
        }

        private void lblHorror_Click(object sender, EventArgs e)
        {
            See();
        }

        private void lblSport_Click(object sender, EventArgs e)
        {
            See();
        }

        private void lblShooter_Click(object sender, EventArgs e)
        {
            See();
        }

        private void lblAutoChess_Click(object sender, EventArgs e)
        {
            See();
        }

        /*private void lblTBS_Click(object sender, EventArgs e)
        {
            See();
        }*/

        private void lblTBT_Click(object sender, EventArgs e)
        {
            See();
        }

        private void lblRacing_Click(object sender, EventArgs e)
        {
            See();
        }

        private void lblTrivia_Click(object sender, EventArgs e)
        {
            See();
        }
    }
}
