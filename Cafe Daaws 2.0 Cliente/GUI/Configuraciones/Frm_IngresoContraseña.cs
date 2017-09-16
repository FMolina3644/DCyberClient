using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Cliente.GUI
{
    public partial class Frm_IngresoContraseña : Form
    {
        bool PuedeCerrar = false;

        public Frm_IngresoContraseña()
        {
            InitializeComponent();
        }

        private void LlamarConfiguraciones()
        {
            GUI.Configuraciones.Frm_Configuraciones FrmConfig = new Configuraciones.Frm_Configuraciones();
            FrmConfig.ShowDialog();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_IngresoContraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PuedeCerrar)
            {
                MessageBox.Show("Debe finalizar la etapa de configuración de su equipo", "Alerta");
                e.Cancel = true;
            }
        }

        private void Txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Btn_Aceptar.Enabled = (((Control)sender).Text.Length > 0);
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Configuraciones.Configuraciones_BLL Config = new BLL.Configuraciones.Configuraciones_BLL();
                if (Txt_Contraseña.Text != Txt_ConfContraseña.Text)
                {
                    MessageBox.Show("Las contraseñas deben ser similares");
                }
                else
                {
                    Config.GuardarContraseña(Txt_Contraseña.Text);
                    MessageBox.Show("Su contraseña ha sido ingresada con éxito");
                    LlamarConfiguraciones();
                    PuedeCerrar = true;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}