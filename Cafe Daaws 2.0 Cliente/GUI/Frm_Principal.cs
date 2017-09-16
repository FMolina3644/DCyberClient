using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Cliente
{
    public partial class Frm_Principal : Form
    {
        BLL.Configuraciones.Configuraciones_BLL Config = new BLL.Configuraciones.Configuraciones_BLL();

        Cafe_Daaws_2._0_Servidor.ENT.Terminal_ENT Cliente = new _0_Servidor.ENT.Terminal_ENT();
        public static bool PuedeCerrar = false;

        public static string IpServidor = "";
        String ContenidoRecibido;
        bool ConectandoHost = false;

        public IntPtr HWND_TaskBar;
        public IntPtr HWND_TrayNotify;
        public IntPtr HWND_Iconos;
        public IntPtr HWND_Reloj;
        public IntPtr HWND_Inicio;

        public Frm_Principal()
        {
            InitializeComponent();
            Cliente.Equipo = Convert.ToString(Dns.GetHostName());
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                if (RegistrarEnInicio())
                {
                    InicializarCliente();
                    HabilitarControles(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region "Metodos & Funciones"
        private bool RegistrarEnInicio()
        {
            try
            {
                string RutaEjecutable = Application.ExecutablePath;
                string NombreApp = Application.ProductName;
                bool ExisteRegistro = false;

                if (!NombreApp.StartsWith("\"") && NombreApp.IndexOf(" ") > -1)
                {
                    NombreApp = "\"" + NombreApp + "\"";
                }

                RegistryKey Registro = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                ExisteRegistro = Registro.GetValue(NombreApp) != null;

                //if (!ExisteRegistro) { Registro.SetValue(NombreApp, RutaEjecutable); }

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar la aplicación en el inicio del sistema operativo. Seguramente no tienes privilegios suficiente. Cierre la aplicación y ejecutela como administrador");
                return false;
            }
        }

        private void EnviarOrdenAServidor(string Orden)
        {
            if (Cafe_Daaws_2._0_Servidor.InterfazNet.ValidarConexion(Cliente.TCP))
            {
                if (ConectandoHost & Orden.Substring(0,1) != "H")
                {
                    return;
                }
                Cafe_Daaws_2._0_Servidor.InterfazNet.Send(Cliente.TCP, Orden);
            }
        }

        private void CerrarConexion()
        {
            if (Cliente.TCP.Connected)
            {
                EnviarOrdenAServidor("SS" + Cliente.Puerto.ToString());
                Cliente.TCP.Close();
            }
        }

        private void MostrarEnsamblados(int Mostrar)
        {
            ExtensionesCOM.ShowWindow(HWND_TaskBar, Mostrar);
            ExtensionesCOM.ShowWindow(HWND_Iconos, Mostrar);
            ExtensionesCOM.ShowWindow(HWND_Inicio, Mostrar);
            ExtensionesCOM.ShowWindow(HWND_TrayNotify, Mostrar);
            ExtensionesCOM.ShowWindow(HWND_Reloj, Mostrar);
        }

        private void LlamarConfiguraciones()
        {
            if (Config.HayContraseñaConfigurada())
            {
                GUI.Configuraciones.Frm_Login FrmConfig = new GUI.Configuraciones.Frm_Login();
                FrmConfig.ShowDialog();
            }
            else
            {
                GUI.Frm_IngresoContraseña FrmConfig = new GUI.Frm_IngresoContraseña();
                FrmConfig.ShowDialog();
            }
            InicializarCliente();
        }

        private void ConfigurarServidor()
        {
            Cursor.Show();
            Tmr_Cronos.Enabled = false;
            Tmr_Bloquear.Enabled = false;
            LlamarConfiguraciones();
        }

        private void BuscarIp()
        {
            try
            {
                IpServidor = Config.ObtenerNombreServidor();
                IPHostEntry IpHE = Dns.GetHostEntry(IpServidor);
                IpServidor = IpHE.AddressList.ToList()
                             .FindAll(P => P.AddressFamily == AddressFamily.InterNetwork)
                             .FirstOrDefault().ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void InicializarCliente()
        {
            try
            {
                Cliente.TCP = new TcpClient();
                if (string.IsNullOrEmpty(Config.ObtenerNombreServidor()))
                {
                    ConfigurarServidor();
                }
                else
                {
                    BuscarIp();
                }

                Tmr_Conexion.Enabled = true;
                HWND_TaskBar = ExtensionesCOM.FindWindow("Shell_TrayWnd", null);
                HWND_Inicio = ExtensionesCOM.FindWindow("BUTTON", null);
                HWND_TrayNotify = ExtensionesCOM.FindWindowEx(HWND_TaskBar, 0, "TrayNotifyWnd", null);
                HWND_Iconos = ExtensionesCOM.FindWindowEx(HWND_TrayNotify, 0, "Syspager", null);
                HWND_Reloj = ExtensionesCOM.FindWindowEx(HWND_TrayNotify, 0, "TrayClockWClass", null);

            }
            catch (Exception ex)
            {
                if (ex.Message == "Host desconocido")
                {
                    if (MessageBox.Show("No se encontró el servidor configurado para el cliente, Desea Configurarlo?",
                                        "Error En Configuracion", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        ConfigurarServidor();
                        InicializarCliente();
                    }
                    else
                    {
                        MessageBox.Show("Se cerrará la aplicación debido a que no encuentra conexión al servidor.");
                        PuedeCerrar = true;
                        Application.Exit();
                    }
                }
                else
                {
                    throw ex;
                }
            }
        }

        private void CargarNombreServidor()
        {
            string Nombre = Config.ObtenerRazonSocial();
            Lbl_TitRazonSocial.Text = Nombre;
        }

        private void HabilitarControles(bool DesBloquear)
        {
            int Mostrar;
            if (!DesBloquear)
            {
                HabilitarPantalla(false);
                Btn_Cerrar.Enabled = false;
                Btn_Chat.Enabled = false;
                CargarNombreServidor();
                Lbl_Tiempo.Text = "";
                Mostrar = 0;
            }
            else
            {
                Tmr_Bloquear.Enabled = false;
                this.BackgroundImage = null;
                Cursor.Show();
                this.TopMost = false;
                this.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, 35);
                Mostrar = 1;
            }

            MostrarEnsamblados(Mostrar);
            Tmr_Cronos.Enabled = DesBloquear;
            Pnl_Contador.Visible = DesBloquear;
        }

        protected override Boolean ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if ((msg.Msg == 0x104) && (((int)msg.LParam) == 0x203e0001))
                return true;
            return false;
        }

        private void ConectarConServidor()
        {
            try
            {
                int Puerto = 5000;
                if (Cliente.TCP != null && !Cafe_Daaws_2._0_Servidor.InterfazNet.ValidarConexion(Cliente.TCP))
                {
                    Cliente.TCP.Close();
                    Cliente.TCP = new TcpClient();
                    Cliente.TCP.Connect(IpServidor, Puerto);
                    Lbl_Tiempo.Text = "Estableciendo La Conexion...";
                }
                else
                {
                    if (Cliente.TCP.Available > 0)
                    {
                        if (Cliente.TiempoConsumido.TotalSeconds > 0) { Tmr_BuscarConex.Enabled = false; }
                        ContenidoRecibido = Cafe_Daaws_2._0_Servidor.InterfazNet.Get(Cliente.TCP);
                        Cliente.Puerto = Convert.ToInt32(ContenidoRecibido);
                        ConectandoHost = true;
                        EnviarOrdenAServidor("H" + Cliente.Equipo + "/" + GetUserName());
                        ConectandoHost = false;
                        Cliente.TCP.Close();
                        Cliente.TCP = new TcpClient();
                        Tmr_Conexion.Enabled = false;
                        Tmr_RecibirOrdenes.Enabled = true;
                        if (Cliente.TiempoConsumido.TotalSeconds > 0) { Tmr_BuscarConex.Enabled = true; }
                    }
                }
            }
            catch (Exception)
            {
                Lbl_Tiempo.Text = "Error De Conexion... Reintentando...";
                Tmr_BuscarConex.Enabled = false;
                Tmr_RecibirOrdenes.Enabled = false;
            }
        }

        public StringBuilder GetUserName()
        {
            StringBuilder b = new StringBuilder(100);
            int n = b.Capacity;
            bool rc = ExtensionesCOM.GetUserName(b, ref n);
            return b;
        }

        private void HabilitarPantalla(bool Habilitar)
        {
            if (!Habilitar)
            {
                //this.TopMost = true;
                //Cursor.Hide();
                //this.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                this.BackgroundImage = Properties.Resources.Logo;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                //Tmr_Bloquear.Enabled = true;
            }
        }
        #endregion

        #region "Metodos & Funciones Ordenes Recibidas"
        private void AsignarTiempo(string Orden)
        {
            int MinutosAdicionar;
            TimeSpan TiempoAdicionar;
            bool EsIlimitado = (Orden == "-1");

            Cliente.TieneTiempoIlimitado = EsIlimitado;
            if (!EsIlimitado)
            {
                MinutosAdicionar = Convert.ToInt32(ContenidoRecibido.Substring(1));
                TiempoAdicionar = new TimeSpan(0, MinutosAdicionar, 0);
                Cliente.TiempoConsumir = Cliente.TiempoConsumir.Add(TiempoAdicionar);
            }
            if (!Tmr_Cronos.Enabled) { HabilitarControles(true); }

        }

        private void AbrirChat()
        {
            int NuevoX, NuevoY;

            GUI.Frm_Chat FrmChat = new GUI.Frm_Chat();

            NuevoX = (this.Location.X + this.Width) - FrmChat.Width;
            NuevoY = this.Location.Y + this.Height;

            FrmChat.Show();
            FrmChat.Location = new Point(NuevoX, NuevoY);
        }

        private void ApagarEquipo()
        {
            ExtensionesCOM.Apagar();
        }

        private void Continuar()
        {
            Tmr_Bloquear.Enabled = false;
            this.BackgroundImage = null;
            Cursor.Show();
            this.TopMost = false;
            this.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, 35);
            Tmr_Cronos.Start();
            MostrarEnsamblados(1);
        }

        private void Detener()
        {
            HabilitarPantalla(false);
            Tmr_Cronos.Stop();
            MostrarEnsamblados(0);
        }

        private void CerrarAplicacion()
        {
            if (Tmr_Cronos.Enabled)
            {
                Cliente.TCP.Close();
                Cliente.TCP = new TcpClient();
                Tmr_Cronos.Enabled = false;
                PuedeCerrar = true;
                Application.Exit();
            }
        }

        private void EstablecerNombreServidor()
        {
            try
            {
                Config.GuardarRazonSocial(ContenidoRecibido.Substring(1));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarMensajeAdvertencia()
        {
            TimeSpan TiempoRestante = Cliente.TiempoConsumir.Subtract(Cliente.TiempoConsumido);
            if ((TiempoRestante.Minutes == 5 | TiempoRestante.Minutes == 2) & TiempoRestante.Seconds == 0)
            {
                GUI.Frm_Advertencia FrmAdvert = new GUI.Frm_Advertencia(TiempoRestante.Minutes);
                FrmAdvert.Show();
            }
            else if (TiempoRestante == new TimeSpan())
            {
                EnviarOrdenAServidor("BB" + Cliente.Puerto.ToString());
                Cliente.ReiniciarFactura();
                HabilitarControles(false);
            }
        }

        #endregion

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarConexion();
            MostrarEnsamblados(1);
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.TaskManagerClosing) { MessageBox.Show("No esta permitido. Desbloquee el equipo desde el panel de configuración"); e.Cancel = true; return; }
            if (!PuedeCerrar) { e.Cancel = true; return; }
            CerrarConexion();
        }

        private void Frm_Principal_KeyUp(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Alt) + Convert.ToInt32(Keys.I))
            {
                ConfigurarServidor();
            }
        }

        /// <summary>
        /// temporizador que se encarga de conectar el cliente al servidor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Conexion_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            ConectarConServidor();
        }

        private void Tmr_RecibirOrdenes_Tick(object sender, EventArgs e)
        {
            string PuertoRecibido;
            try
            {
                if (Cliente.TCP != null && !Cafe_Daaws_2._0_Servidor.InterfazNet.ValidarConexion(Cliente.TCP))
                {
                    Cliente.TCP.Connect(IpServidor, Cliente.Puerto);
                    Lbl_Tiempo.Text = Cliente.TCP.Client.RemoteEndPoint.ToString();
                    PuertoRecibido = Cliente.TCP.Client.RemoteEndPoint.ToString();
                    PuertoRecibido = PuertoRecibido.Substring(PuertoRecibido.Length - 4, 4);
                    Cliente.Puerto = Convert.ToInt32(PuertoRecibido);
                }
                else
                {
                    if (Cliente.TCP.Available > 0)
                    {
                        ContenidoRecibido = Cafe_Daaws_2._0_Servidor.InterfazNet.Get(Cliente.TCP);

                        switch (ContenidoRecibido)
                        {
                            case "-1":
                                AsignarTiempo(ContenidoRecibido);
                                break;
                            case "SMS":
                                AbrirChat();
                                break;
                            case "SD":
                                ApagarEquipo();
                                break;
                            case "TI":
                                AsignarTiempo(ContenidoRecibido);
                                break;
                            case "Cont":
                                Continuar();
                                break;
                            case "BB":
                                Detener();
                                break;
                            case "Bloq":
                                Cliente.ReiniciarFactura();
                                HabilitarControles(false);
                                break;
                            case "SS":
                                CerrarAplicacion();
                                break;
                            default:
                                switch (ContenidoRecibido.Substring(0, 1))
                                {
                                    case "T":
                                        AsignarTiempo(ContenidoRecibido);
                                        break;
                                    case "N":
                                        EstablecerNombreServidor();
                                        break;
                                    default:
                                        Lbl_Tiempo.Text = ContenidoRecibido;
                                        Pnl_Contador.Visible = false;
                                        Cliente.TCP.Close();
                                        Cliente.TCP = new TcpClient();
                                        Tmr_Conexion.Enabled = true;
                                        Tmr_RecibirOrdenes.Enabled = false;
                                        break;
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                Lbl_Tiempo.Text = "Error De Conexion. . . ";
                Tmr_Conexion.Enabled = true;
                Tmr_RecibirOrdenes.Enabled = false;
            }
        }

        private void Tmr_Bloquear_Tick(object sender, EventArgs e)
        {
            ExtensionesCOM.SetCursorPos(0, 0);
            this.Activate();
            this.SetTopLevel(true);
        }

        private void Tmr_Cronos_Tick(object sender, EventArgs e)
        {
            string DescripcionTiempo = "";
            TimeSpan TiempoAdicionar = new TimeSpan(0, 0, 1);
            Cliente.TiempoConsumido = Cliente.TiempoConsumido.Add(TiempoAdicionar);

            if (Cliente.TieneTiempoIlimitado)
            {
                DescripcionTiempo = "Ilimitado";
                Lbl_Contador.Text = Cliente.TiempoConsumido.ToString();
            }
            else
            {
                DescripcionTiempo = Cliente.TiempoConsumir.ToString();
                Lbl_Contador.Text = Cliente.TiempoConsumir.Subtract(Cliente.TiempoConsumido).ToString();
            }

            if (Cafe_Daaws_2._0_Servidor.InterfazNet.ValidarConexion(Cliente.TCP))
            {
                Lbl_Tiempo.Text = DescripcionTiempo;
                Tmr_BuscarConex.Enabled = true;
            }

            MostrarMensajeAdvertencia();
        }

        private void Tmr_BuscarConex_Tick(object sender, EventArgs e)
        {
            Btn_Chat.Enabled = true;
            Btn_Cerrar.Enabled = true;

            //Application.DoEvents();
            EnviarOrdenAServidor("TF" + Cliente.TiempoConsumido.ToString());
        }

        private void Btn_Chat_Click(object sender, EventArgs e)
        {
            AbrirChat();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("¿Realmente Desea Cerrar Su Sesion \r\n Esta Acción Le Desconectará Y Sera Cobrado Automaticamente?", "¿Cerrar Sesion?", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (Res == DialogResult.OK)
            {
                try
                {
                    EnviarOrdenAServidor("BB" + Cliente.Puerto.ToString());
                    Cliente.ReiniciarFactura();
                    HabilitarControles(false);
                }
                catch (Exception)
                {
                    MessageBox.Show("Seleccione Una Maquina");
                }
            }
        }

    }
}