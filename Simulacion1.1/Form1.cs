using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void dgvPseudoaletorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPseudoaleatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pntablero_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Prueba1 prueba1 = new Prueba1();
            prueba1.Show();



            this.Hide();
        }

      
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

    
       
        
        private void btnManto_Click(object sender, EventArgs e)
        {
            PruebaM prueba = new PruebaM();
            prueba.Show();
            this.Hide();
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {

        }
    }
}
