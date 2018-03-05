using System;
using System.Runtime.InteropServices;

namespace Simple_Injector
{
    public class Injector
    {
        // DLL imports

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);


    }
}
