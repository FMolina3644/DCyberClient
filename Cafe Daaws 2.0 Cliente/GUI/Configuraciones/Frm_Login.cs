using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Cliente.GUI.Configuraciones
{
    public partial class Frm_Login : Form
    {
        BLL.Configuraciones.Configuraciones_BLL Config = new BLL.Configuraciones.Configuraciones_BLL();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void LlamarConfiguraciones()
        {
            GUI.Configuraciones.Frm_Configuraciones FrmConfig = new Frm_Configuraciones();
            FrmConfig.ShowDialog();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Config.AccesoPermitido(Txt_Contraseña.Text))
                {
                    LlamarConfiguraciones();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La contraseña no es válida");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Btn_Aceptar.Enabled = (Txt_Contraseña.TextLength > 0);
        }

    }
}
