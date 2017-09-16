using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Cliente
{
    public class InterfazNet
    {
        #region Dll
        [DllImport("Netapi32", CharSet = CharSet.Auto, SetLastError = true), SuppressUnmanagedCodeSecurityAttribute]
        public static extern int NetServerEnum(
            string ServerNane,
            int dwLevel,
            ref IntPtr pBuf,
            int dwPrefMaxLen,
            out int dwEntriesRead,
            out int dwTotalEntries,
            int dwServerType,
            string domain,
            out int dwResumeHandle
            );
        [DllImport("Netapi32", SetLastError = true), SuppressUnmanagedCodeSecurityAttribute]
        public static extern int NetApiBufferFree(
            IntPtr pBuf);
        [StructLayout(LayoutKind.Sequential)]
        public struct _SERVER_INFO_100
        {
            internal int sv100_platform_id;
            [MarshalAs(UnmanagedType.LPWStr)]
            internal string sv100_name;
        }
        #endregion

        public ArrayList BuscarEquiposEnRed()
        {
            ArrayList Buscar = new ArrayList();
            const int MAX_PREFERRED_LENGTH = -1;
            int SV_TYPE_WORKSTATION = 1;
            int SV_TYPE_SERVER = 2;
            IntPtr buffer = IntPtr.Zero;
            IntPtr tmpBuffer = IntPtr.Zero;
            int entriesRead = 0;
            int totalEntries = 0;
            int resHandle = 0;
            int sizeofINFO = Marshal.SizeOf(typeof(_SERVER_INFO_100));
            try
            {

                int ret = NetServerEnum(null, 100, ref buffer, MAX_PREFERRED_LENGTH, out entriesRead, out totalEntries, SV_TYPE_WORKSTATION | SV_TYPE_SERVER, null, out resHandle);
                if (ret == 0)
                {
                    for (int i = 0; i < totalEntries; i++)
                    {
                        tmpBuffer = new IntPtr((int)buffer + (i * sizeofINFO));
                        _SERVER_INFO_100 svrInfo = (_SERVER_INFO_100)Marshal.PtrToStructure(tmpBuffer, typeof(_SERVER_INFO_100));
                        Buscar.Add(svrInfo.sv100_name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Intentar Acceder A La Red " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                NetApiBufferFree(buffer);
            }
            return Buscar;
        }
    }
}
