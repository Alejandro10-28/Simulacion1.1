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
    public partial class PruebaM : Form
    {

        public PruebaM()
        {
            InitializeComponent();
            dgvMuestra.Rows.Add("Alto grado de acidez", "0.18", "0", "0");
            dgvMuestra.Rows.Add("Estado de anemia aguda", "0.08", "0", "0");
            dgvMuestra.Rows.Add("Estado en rango normal", "0.35", "0", "0");
            dgvMuestra.Rows.Add("Exceso de glucosa", "0.17", "0", "0");
            dgvMuestra.Rows.Add("Alto grado de alcalinidad", "0.22", "0", "0");

            dgvContaminantes.Rows.Add("Substancias coloidales", "0.05", "0", "0");
            dgvContaminantes.Rows.Add("Exceso de mercurio", "0.10", "0", "0");
            dgvContaminantes.Rows.Add("Residuos petroquimicos", "0.25", "0", "0");
            dgvContaminantes.Rows.Add("Sulfatos", "0.15", "0", "0");
            dgvContaminantes.Rows.Add("Acido Clorhidrico", "0.12", "0", "0");
            dgvContaminantes.Rows.Add("Fosfato", "0.16", "0", "0");
            dgvContaminantes.Rows.Add("óxidos", "0.17", "0", "0");

        }

        private void btnGenerador_Click(object sender, EventArgs e)
        {
            try
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
                    //dgvPseudoaleatorio.Rows[r].Cells[3].Value = aux;
                    //dgvPseudoaleatorio.Rows[r].Cells[4].Value = most;

                    aux %= M;
                    aux = aux / M;
                    arr[i] = aux;
                    x0 = Convert.ToInt32(aux * M);

                    dgvPseudoaleatorio.Rows[r].Cells[1].Value = aux.ToString();
                    //dgvPseudoaleatorio.Rows[r].Cells[2].Value = i.ToString() + "--" + x0.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void dgvMuestra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void BtnCalculo_Click(object sender, EventArgs e)
        {
            try
            {


                int con = 2;
                int con2 = 2;
                for (int x = 0; x < 5; x++)
                {


                    double c = Convert.ToDouble(dgvMuestra.Rows[x].Cells[1].Value) + Convert.ToDouble(dgvMuestra.Rows[x].Cells[2].Value);
                    if (con == 6)
                    {
                        con = con - 1;
                    }
                    dgvMuestra.Rows[x].Cells[3].Value = c;

                    if (x != 4)
                    {
                        dgvMuestra.Rows[con - 1].Cells[2].Value = Convert.ToDouble(dgvMuestra.Rows[x].Cells[3].Value);

                    }
                    else
                    {
                        dgvMuestra.Rows[con - 1].Cells[2].Value = Convert.ToDouble(dgvMuestra.Rows[x - 1].Cells[3].Value);

                    }
                    con++;
                }
                for (int i = 0; i < 7; i++)
                {
                    double r = Convert.ToDouble(dgvContaminantes.Rows[i].Cells[1].Value) + Convert.ToDouble(dgvContaminantes.Rows[i].Cells[2].Value);
                    if (con2 == 8)
                    {
                        con2 = con2 - 1;
                    }
                    dgvContaminantes.Rows[i].Cells[3].Value = r;

                    if (i != 6)
                    {
                        dgvContaminantes.Rows[con2 - 1].Cells[2].Value = Convert.ToDouble(dgvContaminantes.Rows[i].Cells[3].Value);

                    }
                    else
                    {
                        dgvContaminantes.Rows[con2 - 1].Cells[2].Value = Convert.ToDouble(dgvContaminantes.Rows[i - 1].Cells[3].Value);

                    }
                    con2++;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dgvContaminantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
           
            Comparar();
        }

        public void CompararContaminantes()
        {
            try
            {
                int cont1 = 0, SC = 0, EM = 0, RP = 0, SF = 0, AC = 0, FF = 0, OX = 0;
                int m = 4;
                m = m * int.Parse(txtN.Text);
                for (int x = 0; x < m; x++)
                {
                    int r = dgvResultadoContaminantes.Rows.Add();
                    for (int cont = 0; cont < 4; cont++)
                    {
                        if (cont1 < m)
                        {
                            dgvResultadoContaminantes.Rows[r].Cells[cont].Value = dgvValores.Rows[cont1].Cells[1].Value;
                            if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[1].Value) >= Convert.ToDouble(dgvContaminantes.Rows[0].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvContaminantes.Rows[0].Cells[3].Value))
                            {
                                SC++;
                                //if (SC == 3)
                                //{
                                dgvResultadoContaminantes.Rows[r].Cells[cont + 4].Value = "Substancias coloidales";
                                //    SC = 0;
                                //}
                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvContaminantes.Rows[1].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvContaminantes.Rows[1].Cells[3].Value))
                            {
                                EM++;
                                //if (EM == 3)
                                //{
                                dgvResultadoContaminantes.Rows[r].Cells[cont + 4].Value = "Exceso de mercurio";
                                //    EM = 0;
                                //}

                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvContaminantes.Rows[2].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvContaminantes.Rows[2].Cells[3].Value))
                            {
                                RP++;
                                //if (RP == 3)
                                //{
                                dgvResultadoContaminantes.Rows[r].Cells[cont + 4].Value = "Residuos petroquimicos";
                                //    RP = 0;
                                //}

                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvContaminantes.Rows[3].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvContaminantes.Rows[3].Cells[3].Value))
                            {
                                SF++;
                                //if (SF == 3)
                                //{
                                dgvResultadoContaminantes.Rows[r].Cells[cont + 4].Value = "Sulfatos";
                                //    SF = 0;
                                //}

                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvContaminantes.Rows[4].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvContaminantes.Rows[4].Cells[3].Value))
                            {
                                AC++;
                                //if (AC == 3)
                                //{
                                dgvResultadoContaminantes.Rows[r].Cells[cont + 4].Value = "Acido clorhidrico";
                                //    AC = 0;
                                //}
                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvContaminantes.Rows[5].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvContaminantes.Rows[5].Cells[3].Value))
                            {
                                FF++;
                                //if (FF == 3)
                                //{
                                dgvResultadoContaminantes.Rows[r].Cells[cont + 4].Value = "Fosfato";
                                //    FF = 0;
                                //}
                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvContaminantes.Rows[6].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvContaminantes.Rows[6].Cells[3].Value))
                            {
                                OX++;
                                //if (OX == 3)
                                //{
                                dgvResultadoContaminantes.Rows[r].Cells[cont + 4].Value = "Oxidos";
                                //    OX= 0;
                                //}
                            }




                            cont1++;
                        }
                        else
                        {
                            break;
                        }


                    }

                    //OX = 0;
                    //SF = 0;
                    //AC = 0;
                    //EM = 0;
                    //FF = 0;
                    //RP = 0;
                    //SC = 0;

                }
                dgvContaminantes.Rows[0].Cells[4].Value = SC.ToString();
                dgvContaminantes.Rows[1].Cells[4].Value = EM.ToString();
                dgvContaminantes.Rows[2].Cells[4].Value = RP.ToString();
                dgvContaminantes.Rows[3].Cells[4].Value = SF.ToString();
                dgvContaminantes.Rows[4].Cells[4].Value = AC.ToString();
                dgvContaminantes.Rows[5].Cells[4].Value = FF.ToString();
                dgvContaminantes.Rows[6].Cells[4].Value = OX.ToString();

                int Temp = 0;
                string R1 = "";
                foreach (DataGridViewRow C in dgvContaminantes.Rows)
                {

                    if (Temp < Convert.ToInt32(dgvContaminantes.Rows[C.Index].Cells[4].Value))
                    {
                        Temp = Convert.ToInt32(dgvContaminantes.Rows[C.Index].Cells[4].Value);
                        R1 = Convert.ToString(dgvContaminantes.Rows[C.Index].Cells[0].Value);
                    }
                }
                lblContaminantes.Text = "El estado que mas se repitio fue:\n" + R1.ToString() + "\nCon un total de:\n" + Temp.ToString() + "  repeticiones";
            }
            catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                int v = 0, m = 0;
                double[] lis1 = new double[dgvPseudoaleatorio.RowCount];
                double[] lis2 = new double[dgvPseudoaleatorio.RowCount];

                v = int.Parse(txtV1.Text);
                m = int.Parse(txtv2.Text) - int.Parse(txtV1.Text);
                for (int x = 0; x <= m; x++)
                {
                    int r = dgvValores.Rows.Add();


                    lis1[x] = Convert.ToDouble(dgvPseudoaleatorio.Rows[v - 1].Cells["Crn"].Value);

                    dgvValores.Rows[r].Cells[0].Value = lis1[x];

                    v++;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n"+ ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            try
            {
                int v = 0, m = 0;
                int cont = 0;
                double[] lis2 = new double[dgvPseudoaleatorio.RowCount];

                v = int.Parse(txtV1.Text);
                m = int.Parse(txtv2.Text) - int.Parse(txtV1.Text);
                for (int x = 0; x <= m; x++)
                {
                    int r = dgvValores.Rows.Add();


                    lis2[x] = Convert.ToDouble(dgvPseudoaleatorio.Rows[v - 1].Cells["Crn"].Value);
                    if (cont <= dgvValores.RowCount)
                    {


                        dgvValores.Rows[cont].Cells[1].Value = lis2[x];
                    }
                    else
                    {
                        dgvValores.Rows[r].Cells[1].Value = lis2[x];

                    }
                    v++;
                    cont++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n"+ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        public void Comparar()
        {
            try
            {
                int cont1 = 0, AC = 0, EA = 0, ERN = 0, EG = 0, AG = 0;
                int m = 3;
                m = m * int.Parse(txtN.Text);
                for (int x = 0; x < m; x++)
                {
                    int r = dgvresultado.Rows.Add();
                    for (int cont = 0; cont < 3; cont++)
                    {
                        if (cont1 < m)
                        {
                            dgvresultado.Rows[r].Cells[cont].Value = dgvValores.Rows[cont1].Cells[0].Value;
                            if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvMuestra.Rows[0].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvMuestra.Rows[0].Cells[3].Value))
                            {
                                AC++;
                                //if (AC == 2)
                                //{
                                dgvresultado.Rows[r].Cells[cont + 3].Value = "Alto grado de acidez";
                                //    AC = 0;
                                //}
                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvMuestra.Rows[1].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvMuestra.Rows[1].Cells[3].Value))
                            {
                                EA++;
                                //if (EA == 2)
                                //{
                                dgvresultado.Rows[r].Cells[cont + 3].Value = "Estado de anemia aguda";
                                //    EA = 0;
                                //}

                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvMuestra.Rows[2].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvMuestra.Rows[2].Cells[3].Value))
                            {
                                ERN++;
                                //if (ERN == 2)
                                //{
                                dgvresultado.Rows[r].Cells[cont + 3].Value = "Estado en rango normal";
                                //    ERN = 0;
                                //}

                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvMuestra.Rows[3].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvMuestra.Rows[3].Cells[3].Value))
                            {
                                EG++;
                                //if (EG == 2)
                                //{
                                dgvresultado.Rows[r].Cells[cont + 3].Value = "Exceso de glucosa";
                                //    EG = 0;
                                //}

                            }
                            else if (Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) >= Convert.ToDouble(dgvMuestra.Rows[4].Cells[2].Value) && Convert.ToDouble(dgvValores.Rows[cont1].Cells[0].Value) <= Convert.ToDouble(dgvMuestra.Rows[4].Cells[3].Value))
                            {
                                AG++;
                                //if (AG == 2)
                                //{
                                dgvresultado.Rows[r].Cells[cont + 3].Value = "Alto grado de alcalinidad";
                                //    AG = 0;
                                //}
                            }


                            cont1++;
                        }
                        else
                        {
                            break;
                        }


                    }
                    //AG = 0;
                    //EG = 0;
                    //ERN = 0;
                    //EA = 0;
                    //AC = 0;
                    // cont = 0;

                }
                dgvMuestra.Rows[0].Cells[4].Value = AC.ToString();
                dgvMuestra.Rows[1].Cells[4].Value = EA.ToString();
                dgvMuestra.Rows[2].Cells[4].Value = ERN.ToString();
                dgvMuestra.Rows[3].Cells[4].Value = EG.ToString();
                dgvMuestra.Rows[4].Cells[4].Value = AG.ToString();
                int Temp = 0;
                string R1 = "";
                foreach (DataGridViewRow M in dgvMuestra.Rows)
                {

                    if (Temp < Convert.ToInt32(dgvMuestra.Rows[M.Index].Cells[4].Value))
                    {
                        Temp = Convert.ToInt32(dgvMuestra.Rows[M.Index].Cells[4].Value);
                        R1 = Convert.ToString(dgvMuestra.Rows[M.Index].Cells[0].Value);
                    }
                }
                lblRespuestaMuestra.Text = "El estado que mas se repitio fue:\n" + R1.ToString() + "\nCon un total de:\n" + Temp.ToString() + "  repeticiones";
            }catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        //if (AC >= 2)
        //        {
        //            dgvresultado.Rows[r].Cells[3].Value = "Alto grado de acidez";

        //        }
        //        else if (EA >= 2)
        //        {
        //            dgvresultado.Rows[r].Cells[3].Value = "Estado de anemia aguda";

        //        }
        //        else if (ERN >= 2)
        //        {
        //            dgvresultado.Rows[r].Cells[3].Value = "Estado en rango normal";

        //        }
        //        else if (EG >= 2)
        //        {
        //            dgvresultado.Rows[r].Cells[3].Value = "Exceso de glucosa";

        //        }
        //        else if (AG >= 2)
        //        {
        //            dgvresultado.Rows[r].Cells[3].Value = "Alto grado de alcalinidad";

        //        }

        private void dgvresultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCompararContaminantes_Click(object sender, EventArgs e)
        {
            CompararContaminantes();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPseudoaleatorio.Rows.Clear();
                dgvValores.Rows.Clear();
                dgvContaminantes.Rows.Clear();
                dgvresultado.Rows.Clear();
                dgvResultadoContaminantes.Rows.Clear();
                dgvMuestra.Rows.Clear();

                dgvMuestra.Rows.Add("Alto grado de acidez", "0.18", "0", "0");
                dgvMuestra.Rows.Add("Estado de anemia aguda", "0.08", "0", "0");
                dgvMuestra.Rows.Add("Estado en rango normal", "0.35", "0", "0");
                dgvMuestra.Rows.Add("Exceso de glucosa", "0.17", "0", "0");
                dgvMuestra.Rows.Add("Alto grado de alcalinidad", "0.22", "0", "0");

                dgvContaminantes.Rows.Add("Substancias coloidales", "0.05", "0", "0");
                dgvContaminantes.Rows.Add("Exceso de mercurio", "0.10", "0", "0");
                dgvContaminantes.Rows.Add("Residuos petroquimicos", "0.25", "0", "0");
                dgvContaminantes.Rows.Add("Sulfatos", "0.15", "0", "0");
                dgvContaminantes.Rows.Add("Acido Clorhidrico", "0.12", "0", "0");
                dgvContaminantes.Rows.Add("Fosfato", "0.16", "0", "0");
                dgvContaminantes.Rows.Add("óxidos", "0.17", "0", "0");
            }
            catch(Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dgvResultadoContaminantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
