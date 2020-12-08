using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using Meta.Numerics;
using Meta.Numerics.Statistics;
using Meta.Numerics.Statistics.Distributions;
using System.Collections;

namespace Simulacion1._1
{
    
    public partial class Prueba1 : Form
    {
        Form1 form1 = new Form1();
        MathNet.Numerics.Distributions.Normal dnormal = new MathNet.Numerics.Distributions.Normal();
       

        public Prueba1()
        {
            InitializeComponent();
        }

       
        

        private void Prueba1_Load(object sender, EventArgs e)
        {


        }

        private void BtnPromedios_Click(object sender, EventArgs e)
        {
            double acumulador = 0;
            double promedio = 0, Alfa = 100, Z, Distribucion,LimI,LimS;
            

            Alfa = (Alfa - Convert.ToDouble(txtConfianza.Text)) / 100;
            txtAlfa.Text = Alfa.ToString();
            Z = 1 - (Alfa / 2);
            txtZ.Text = Z.ToString();
            Distribucion =Math.Round(Math.Abs(dnormal.InverseCumulativeDistribution(Z)),2);
            txtDistribucion.Text = Distribucion.ToString();
            LimI = 0.5 - (Distribucion * (1 / Math.Sqrt(12 * Convert.ToDouble(txtCantidad.Text))));
            LimS = 0.5 + (Distribucion * (1 / Math.Sqrt(12 * Convert.ToDouble(txtCantidad.Text))));
            txtLI.Text = LimI.ToString();
            txtLS.Text = LimS.ToString();
            foreach (DataGridViewRow i in dgvPseudoaleatorio.Rows)
            {

                acumulador += Convert.ToDouble(i.Cells["Crn"].Value);
            }
            promedio = acumulador / dgvPseudoaleatorio.RowCount;
            txtPromedio.Text = promedio.ToString();
            if (promedio>=LimI && promedio <= LimS)
            {
                lblr.Text = "Los números estan distribuidos uniformemente";
            }
            else
            {
                lblr.Text = "Los números no están distribuidos uniformemente";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnVarianza_Click(object sender, EventArgs e)
        {
            double[] num = new double[dgvPseudoaleatorio.RowCount];
            double[] corr = new double[dgvPseudoaleatorio.RowCount];
            double acumulador = 0, Varianza, ValorE = 0, destadistico,con=0;
            int contador1 = 0, corridas = 0;
            foreach (DataGridViewRow i in dgvPseudoaleatorio.Rows)
            {

                num[contador1] = Convert.ToDouble(i.Cells["Crn"].Value);
                acumulador += Math.Pow(Convert.ToDouble(i.Cells["Crn"].Value) - Convert.ToDouble(txtPromedio.Text), 2);
                contador1++;
            }
            for(int c = 1; c < dgvPseudoaleatorio.RowCount; c++)
            {
                int r = dgvCorridas.Rows.Add();
                dgvCorridas.Rows[r].Cells[1].Value = c;
                if (num[c]>  num[c - 1])
                { 
                    dgvCorridas.Rows[r].Cells[0].Value = 1;
                    corr[c-1 ] = 1;
                   
                    
                }
                else
                {
                    dgvCorridas.Rows[r].Cells[0].Value = 0;
                    corr[c -1] = 0;
                    

                }
            }

            for (int a = 1; a < dgvCorridas.RowCount; a++)
            {
                con = Math.Abs(corr[a] - corr[a - 1]);

                if (con != 0)
                {
                    corridas++;
                    
                }

            }

            Varianza = Math.Sqrt(((16 * (Convert.ToDouble(txtCantidad.Text)) - 29 )/ 90));
            ValorE = (2*(Convert.ToDouble(txtCantidad.Text) )-1)/ 3;
            destadistico = ((corridas - ValorE) / Varianza);

            txtVarianza.Text=Varianza.ToString();
            txtDestadisticos.Text = destadistico.ToString();
            txtVe.Text = ValorE.ToString();
            txtTotalC.Text = corridas.ToString();
        }

        private void dgvCorridas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pntablero_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pbxMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            int x0, A, C, M, n;

            n = int.Parse(txtCantidad.Text);
            float[] arr = new float[n];
            x0 = int.Parse(txtX.Text);
            A = int.Parse(txta.Text);
            C = int.Parse(txtc.Text);
            M = int.Parse(txtm.Text);

            for (int i = 0; i < n; i++)
            {
                int r = dgvPseudoaleatorio.Rows.Add();
                dgvPseudoaleatorio.Rows[r].Cells[0].Value = i + 1;

                float aux = (x0 * A + C);
                float most = x0 * A;
                dgvPseudoaleatorio.Rows[r].Cells[3].Value = aux;
                dgvPseudoaleatorio.Rows[r].Cells[4].Value = most;

                aux %= M;
                aux = aux / M;
                arr[i] = aux;
                x0 = Convert.ToInt32(aux * M);

                dgvPseudoaleatorio.Rows[r].Cells[1].Value = aux.ToString();
                dgvPseudoaleatorio.Rows[r].Cells[2].Value = i.ToString() + "--" + x0.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Visible = false;
        }
    }
}
