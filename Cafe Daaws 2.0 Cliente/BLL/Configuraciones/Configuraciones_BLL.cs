using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Cliente.BLL.Configuraciones
{
    public class Configuraciones_BLL
    {
        DAL.Configuraciones.Configuraciones_DAL Datos = new DAL.Configuraciones.Configuraciones_DAL();

        public string ObtenerNombreServidor()
        {
            return Datos.ObtenerNombreServidor();
        }

        public string ObtenerRazonSocial()
        {
            return Datos.ObtenerRazonSocial();
        }

        public void GuardarRazonSocial(string RazonSocial)
        {
            try
            {
                Datos.GuardarRazonSocial(RazonSocial);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void GuardarContraseña(string Contraseña)
        {
            try
            {
                Datos.GuardarContraseña(Contraseña);
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
                return Datos.HayContraseñaConfigurada();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool AccesoPermitido(string Contraseña)
        {
            try
            {
                return Datos.AccesoPermitido(Contraseña);
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
                return Datos.ObtenerTipoConfiguracion();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ActualizarDatosServidor(string Nombre, int Estado, int Tipo)
        {
            try
            {
                Datos.ActualizarDatosServidor(Nombre, Estado, Tipo);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
