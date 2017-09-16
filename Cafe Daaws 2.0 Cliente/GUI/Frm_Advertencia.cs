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
    public partial class Frm_Advertencia : Form
    {
        public Frm_Advertencia(int TiempoRestante)
        {
            InitializeComponent();
            InicializarFormulario(TiempoRestante);
        }

        private void InicializarFormulario(int TiempoRestante)
        {
            Lbl_Descripcion.Text = "Quedan " + TiempoRestante.ToString() + "Minutos";
            if (TiempoRestante == 5)
            {
                Btn_Leido.BackColor = Color.LightYellow;
            }
            else
            {
                Btn_Leido.BackColor = Color.DarkRed;
            }
        }

        private void Btn_Leido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
