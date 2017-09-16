using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Cliente.DAL.Configuraciones
{
    public class Configuraciones_DAL
    {
        Cafe_Daaws_2._0_Servidor.DAL.DBConexion bd = new _0_Servidor.DAL.DBConexion("BDClient");

        public string ObtenerNombreServidor()
        {
            string NombreServer = "";
            DbDataReader dr;
            bd.Conectar();
            bd.CrearComando("select host from ip where estado=1");
            dr = bd.EjecutarConsultaReader();
            if (dr.Read())
            {
                NombreServer = Convert.ToString(dr.GetValue(0));
            }
            dr.Close();
            bd.Desconectar();
            return NombreServer;
        }

        public string ObtenerRazonSocial()
        {
            string Nombre = "";
            DbDataReader dr;
            bd.Conectar();
            bd.CrearComando("select * from Nombre");
            dr = bd.EjecutarConsultaReader();
            if (dr.Read())
            {
                Nombre = Convert.ToString(dr.GetValue(0));
            }
            dr.Close();
            bd.Desconectar();
            return Nombre;
        }

        public void GuardarRazonSocial(string vNombre)
        {
            try
            {
                DbDataReader dr;
                bd.Conectar();
                bd.CrearComando("INSERT INTO Nombre([razon_soc]) VALUES (@raz)");
                bd.AsignarParametro("@raz", DbType.String, vNombre);
                dr = bd.EjecutarConsultaReader();
                dr.Close();
                bd.Desconectar();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void GuardarContraseña(string vpassword)
        {
            try
            {
                DbDataReader dr;
                bd.Conectar();
                bd.CrearComando("INSERT INTO Usuario ([pass]) VALUES(@pass)");
                bd.AsignarParametro("@pass", DbType.String, vpassword);
                dr = bd.EjecutarConsultaReader();
                dr.Close();
                bd.Desconectar();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool HayContraseñaConfigurada()
        {
            try
            {
                bool ExisteContraseña = false;
                DbDataReader dr;
                bd.Conectar();
                bd.CrearComando("select * from Usuario");
                dr = bd.EjecutarConsultaReader();
                ExisteContraseña = dr.Read();
                dr.Close();
                bd.Desconectar();
                return ExisteContraseña;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool AccesoPermitido(string vpassword)
        {
            try
            {
                bool permitido = false;
                DbDataReader dr;
                bd.Conectar();
                bd.CrearComando("select * from Usuario where [Pass] = @pass");
                bd.AsignarParametro("@pass", DbType.String, vpassword);
                dr = bd.EjecutarConsultaReader();
                permitido = dr.Read();
                dr.Close();
                bd.Desconectar();
                return permitido;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public int ObtenerTipoConfiguracion()
        {
            try
            {
                int Tipo = 0;
                DbDataReader dr;
                bd.Conectar();
                bd.CrearComando("select [Tipo] from Ip where [Estado]=1");
                dr = bd.EjecutarConsultaReader();
                if (dr.Read())
                {
                    Tipo = Convert.ToInt32(dr.GetValue(0));
                }
                dr.Close();
                bd.Desconectar();
                return Tipo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ActualizarDatosServidor(string NombreServidor, int Estado, int Tipo)
        {
            try
            {
                bd.Conectar();
                string sentenciaSQL = "UPDATE Ip SET [Host] = [@Host], [Estado] = [@Est], [Tipo] = [@Tipo]";
                bd.CrearComando(sentenciaSQL);
                bd.AsignarParametro("@Host", DbType.String, NombreServidor);
                bd.AsignarParametro("@Est", DbType.Int32, Estado);
                bd.AsignarParametro("@Tipo", DbType.Int32, Tipo);
                DbDataReader dr = bd.EjecutarConsultaReader();
                dr.Close();
                bd.Desconectar();
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}
