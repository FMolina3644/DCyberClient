using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Cliente
{
    public class ExtensionesCOM
    {
        [DllImport("user32")]
        public static extern IntPtr FindWindowEx(IntPtr hWnd1, int hWnd2, string lpsz1, string lpsz2);

        [DllImport("user32")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32")]
        public static extern void ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("User32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("advapi32.dll")]
        public static extern bool GetUserName(StringBuilder lpBuffer, ref int nSize);

        public static void Apagar()
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();
            // You can't shutdown without security privileges     
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams = mcWin32.GetMethodParameters("Win32Shutdown");
            // Flag 1 means we want to shut down the system. Use "2" to reboot.      
            mboShutdownParams["Flags"] = "1";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, null);
            } 
        }
         
    }
}
