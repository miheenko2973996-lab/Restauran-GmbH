using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauran_GmbH
{
    public partial class Zugang : Form
    {
        public Zugang()
        {
            InitializeComponent();
        }

        private void panellLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Zugang_Load(object sender, EventArgs e)
        {
            this.Hide();

            ManagerAufgabe managerAufgabe = new ManagerAufgabe();
            managerAufgabe.Show();

            
        }
    }
}
