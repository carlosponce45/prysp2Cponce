using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prysp2Cponce
{
    public partial class FrmReservaDeCabaña : Form
    {
        public FrmReservaDeCabaña()
        {
            InitializeComponent();
        }

        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTipo.SelectedIndex != -1) // metodo de habilitacion 
            {
                CmbPersonas.Enabled = true;
            }

            if (CmbTipo.Text == "A")
            {
                CmbPersonas.Items.Clear();
                CmbPersonas.Items.Add(1);
                CmbPersonas.Items.Add(2);
                CmbPersonas.Items.Add(3);
                CmbPersonas.Items.Add(4);
            }

            if (CmbTipo.Text == "B")
            {
                CmbPersonas.Items.Clear();
                CmbPersonas.Items.Add(1);
                CmbPersonas.Items.Add(2);
                CmbPersonas.Items.Add(3);
                CmbPersonas.Items.Add(4);
                CmbPersonas.Items.Add(5);
                CmbPersonas.Items.Add(6);
            }
        }

        private void CmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPersonas.SelectedIndex != -1)
            {
                TxtDias.Enabled = true;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            CmbTipo.SelectedIndex = 0;
            TxtDias.SelectedText = "1"; // dia fijo 1
            CmbPersonas.SelectedIndex = 0; // deja en 0 lo seleccionado..
        }

        private void TxtDias_TextChanged(object sender, EventArgs e)
        {
            if (TxtDias.Text != "")
            {
                MrcAdcionales.Enabled = true;
                MrcPago.Enabled = true;

                RbEfectivo.Enabled = true;
                RbTarjeta.Enabled = true;
                CmbTarjeta.Enabled = false;
                RbEfectivo.Checked = true;
            }
        }

        private void MrcAdcionales_Enter(object sender, EventArgs e)
        {
            if (TxtDias.Text != "")
            {
                MrcPago.Enabled = true;
            }
        }
        private void RbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (RbTarjeta.Checked)
            {
                CmbTarjeta.Enabled = true;
            }
        }

        private void MrcPago_Enter(object sender, EventArgs e)
        {
            if (TxtDias.Text != "")
            {
                MrcAdcionales.Enabled = true;
            }
        }
        void procedimientodealgo()
        {
            //codigo que ejecute
        }

        string unafuncionretornaunvalor()
        {
            string varAlgo = "";

            return varAlgo;
        }

        private void TxtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (Convert.ToInt32(e.KeyChar.ToString()) > 0)
            {
                MessageBox.Show("soy un numerito " + e.KeyChar.ToString());
            }

            //// only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GbDatos_Enter(object sender, EventArgs e)
        {
            if (TxtDias.Text != "")
            {
                GbDatos.Enabled = true;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            if (TxtDias.Text != "")
            {
                TxtNumero.Enabled = true;
                BtnAceptar.Enabled = true;
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (TxtDias.Text != "")
            {
                TxtDias.Enabled = true;
            }
        }
    }
}


