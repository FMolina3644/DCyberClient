using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Cliente.GUI.Configuraciones
{
    public partial class Frm_Configuraciones : Form
    {
        BLL.Configuraciones.Configuraciones_BLL Config = new BLL.Configuraciones.Configuraciones_BLL();
        string NombreEquipo = Dns.GetHostName();
        int ConfiguracionSeleccionada = 2;

        private const int Mostrar = 1;

        public IntPtr HWND_TaskBar;
        public IntPtr HWND_TrayNotify;
        public IntPtr HWND_Iconos;
        public IntPtr HWND_Reloj;
        public IntPtr HWND_Inicio;

        public Frm_Configuraciones()
        {
            InitializeComponent();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Configuraciones_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        #region "Metodos & Funciones"
        private void InicializarFormulario()
        {
            try
            {
                int Conf = Config.ObtenerTipoConfiguracion();
                ConfiguracionSeleccionada = Conf == 0 ? 2 : Conf;
                SeleccionarConfiguracion();

                if (ConfiguracionSeleccionada == 1) { Txt_Nombre.Text = Config.ObtenerNombreServidor(); }

                InterfazNet Net = new InterfazNet();
                Net.BuscarEquiposEnRed().Cast<string>().ToList()
                   .FindAll(E => E != NombreEquipo)
                   .ForEach(E => Cmb_Equipos.Items.Add(E));

                HWND_TaskBar = ExtensionesCOM.FindWindow("Shell_TrayWnd", null);
                HWND_Inicio = ExtensionesCOM.FindWindow("BUTTON", null);
                HWND_TrayNotify = ExtensionesCOM.FindWindowEx(HWND_TaskBar, 0, "TrayNotifyWnd", null);
                HWND_Iconos = ExtensionesCOM.FindWindowEx(HWND_TrayNotify, 0, "Syspager", null);
                HWND_Reloj = ExtensionesCOM.FindWindowEx(HWND_TrayNotify, 0, "TrayClockWClass", null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SeleccionarConfiguracion()
        {
            List<Control> Ctrls = Controls.Cast<Control>().ToList().FindAll(C => C.Name.Contains("Pnl_") & C.Tag != null);

            //asignamos el color de fondo a los activados
            Ctrls.FindAll(C => C.Tag.ToString() == ConfiguracionSeleccionada.ToString()).ForEach(C => C.BackColor = Color.LightBlue);
            //asignamos el color de fondo a los desactivados
            Ctrls.FindAll(C => C.Tag.ToString() != ConfiguracionSeleccionada.ToString()).ForEach(C => C.BackColor = Color.DimGray);

            if (ConfiguracionSeleccionada == 1)
            {
                Txt_Nombre.Clear();
            }
            else
            {
                Cmb_Equipos.SelectedIndex = -1;
                Lbl_ValIp.Text = "";
            }
        }

        private void GuardarConfiguracion()
        {
            try
            {
                string NombreServidor = "";
                int Estado = 1;
                if (ConfiguracionSeleccionada == 1)
                {
                    if (Txt_Nombre.Text.Length == 0)
                    {
                        MessageBox.Show("Debe ingresar el nombre del equipo para configurar");
                        return;
                    }
                    NombreServidor = Txt_Nombre.Text;
                }
                else
                {
                    if (Cmb_Equipos.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar el equipo servidor para continuar");
                        return;
                    }
                    NombreServidor = Cmb_Equipos.Text;
                }

                Config.ActualizarDatosServidor(NombreServidor, Estado, ConfiguracionSeleccionada);
                MessageBox.Show("La configuración ha sido guardada con éxito", "Actualizado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void Btn_Manual_Click(object sender, EventArgs e)
        {
            ConfiguracionSeleccionada = Convert.ToInt32(((Control)sender).Parent.Tag);
            SeleccionarConfiguracion();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cmb_Equipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Equipos.SelectedIndex == -1)
            {
                Lbl_ValIp.Text = "";
                return;
            }

            string Server = Convert.ToString(Cmb_Equipos.Text);
            IPHostEntry IpHE = Dns.GetHostEntry(Server);
            Lbl_ValIp.Text = IpHE.AddressList.ToList()
                             .FindAll(S => S.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                             .FirstOrDefault().ToString();
        }

        private void Btn_Desconectar_Click(object sender, EventArgs e)
        {
            ExtensionesCOM.ShowWindow(HWND_TaskBar, Mostrar);
            ExtensionesCOM.ShowWindow(HWND_Iconos, Mostrar);
            ExtensionesCOM.ShowWindow(HWND_Inicio, Mostrar);
            ExtensionesCOM.ShowWindow(HWND_TrayNotify, Mostrar);
            ExtensionesCOM.ShowWindow(HWND_Reloj, Mostrar);
            Frm_Principal.PuedeCerrar = true;
            Application.Exit();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
        }

    }
}
