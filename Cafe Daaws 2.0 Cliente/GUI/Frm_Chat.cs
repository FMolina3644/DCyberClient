using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Cliente.GUI
{
    public partial class Frm_Chat : Form
    {
        Socket Sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        Thread Recibir;

        string ContenidoRecibido;
        string NombreEquipo = Dns.GetHostName();

        public Frm_Chat()
        {
            InitializeComponent();
        }

        private void Frm_Chat_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        #region "Metodos & Funciones"
        private void InicializarFormulario()
        {
            Sock.Bind(new IPEndPoint(IPAddress.Any, 5103));
            Sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);
            Recibir = new Thread(RecibirMensajes);
            Recibir.Start();
        }

        private void RecibirMensajes()
        {
            IPEndPoint IPRem = new IPEndPoint(IPAddress.Any, 0);
            EndPoint IPRec = (EndPoint)IPRem;
            byte[] RecBytes = new byte[512];
            string Datos = "";
            try
            {
                Sock.ReceiveFrom(RecBytes, RecBytes.Length, SocketFlags.None, ref IPRec);
                Datos = Encoding.Default.GetString(RecBytes);
            }
            catch (SocketException ex)
            {
                if (ex.ErrorCode == 10040)
                {
                    Datos += "[truncado]";
                }
                else
                {
                    MessageBox.Show("Error '" + ex.ErrorCode + "' " + ex.Message, "Error al recibir los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            IPRem = (IPEndPoint)IPRec;
            ContenidoRecibido = Datos.ToString();
            Rtb_Mensajes.Invoke(new EventHandler(ActualizarMensajes));
        }

        protected void ActualizarMensajes(object sender, EventArgs e)
        {
            if (Rtb_Mensajes.TextLength == 0)
            {
                Rtb_Mensajes.Text = NombreEquipo + " > " + ContenidoRecibido;
            }
            else
            {
                Rtb_Mensajes.Text += "\r\n" + NombreEquipo + " > " + ContenidoRecibido;
            }
        }

        public StringBuilder GetUserName()
        {
            StringBuilder b = new StringBuilder(100);
            int n = b.Capacity;
            bool rc =  ExtensionesCOM.GetUserName(b, ref n);
            return b;
        }

        #endregion

        private void Rtb_Mensajes_TextChanged(object sender, EventArgs e)
        {
            Rtb_Mensajes.SelectionStart = Rtb_Mensajes.TextLength;
            Rtb_Mensajes.ScrollToCaret();
        }

        private void Txt_Mensaje_TextChanged(object sender, EventArgs e)
        {
            Btn_Enviar.Enabled = (Txt_Mensaje.TextLength > 0);
        }

        private void Frm_Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sock.Close();
            if (Recibir != null) { Recibir.Abort(); }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            string Mensaje = NombreEquipo + "/" + GetUserName() + "> " + Txt_Mensaje.Text;

            if (Rtb_Mensajes.TextLength == 0)
            {
                Rtb_Mensajes.Text = NombreEquipo + "/" + GetUserName() + "> " + Txt_Mensaje.Text;
            }
            else
            {
                Rtb_Mensajes.Text += "\r\n" + Mensaje;
            }
            IPEndPoint DirDest = new IPEndPoint(IPAddress.Parse(Frm_Principal.IpServidor), 5103);
            byte[] DateBytes = Encoding.Default.GetBytes(Mensaje);
            Sock.SendTo(DateBytes, DateBytes.Length, SocketFlags.None, DirDest);
            Txt_Mensaje.Clear();
            Txt_Mensaje.Focus();
        }

    }
}