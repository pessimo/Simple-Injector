using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Simple_Injector
{
    public class Injector
    {
        // DLL imports

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        // Privileges 

        private const int ProcessCreateThread = 0x0002;
        private const int ProcessQueryInformation = 0x0400;
        private const int ProcessVmOperation = 0x0008;
        private const int ProcessVmWrite = 0x0020;
        private const int ProcessVmRead = 0x0010;
        private const int ProcessAllAccess = ProcessCreateThread | ProcessQueryInformation | ProcessVmOperation | ProcessVmWrite | ProcessVmRead;

        // Memory Allocation

        private const uint MemoryCommit  = 0x00001000;
        private const uint MemoryReserve  = 0x00002000;
        private const uint PageReadWrite  = 4;

        // Interface Labels

        private readonly Label _loadLibraryALabel;
        private readonly Label _processHandleLabel;
        private readonly Label _allocateMemoryLabel;
        private readonly Label _writeMemoryLabel;
        private readonly Label _createRemoteThreadLabel;

        public Injector(Label a, Label b, Label c, Label d, Label e)
        {
            _loadLibraryALabel = a;
            _processHandleLabel = b;
            _allocateMemoryLabel = c;
            _writeMemoryLabel = d;
            _createRemoteThreadLabel = e;
        }

        public void Inject(string processName, string dllPath)
        {           
            // Get the process id
            
            var processId = Process.GetProcessesByName(processName)[0].Id;
                
            // Get the address of LoadLibraryA
            
            var loadLibraryA = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            if (loadLibraryA == IntPtr.Zero)
            {
                var lastError = Marshal.GetLastWin32Error();

                _loadLibraryALabel.Text = @"Failed to find kernel32.dll";
            }

            else
            {
                _loadLibraryALabel.Text = @"Successfully loaded kernel32.dll";
            }
                        
            // Get the handle for the process
            
            var processHandle = OpenProcess(ProcessAllAccess, false, processId);

            if (processHandle == IntPtr.Zero)
            {
                var lastError = Marshal.GetLastWin32Error();

                _processHandleLabel.Text = @"Failed to get process handle";
            }
            
            else
            {
                _processHandleLabel.Text = @"Successfully found process handle";
            }
            
            // Allocate memory in the process
            
            var memory = VirtualAllocEx(processHandle, IntPtr.Zero, (uint)(dllPath.Length + 1), MemoryCommit | MemoryReserve, PageReadWrite);
            
            if (memory == IntPtr.Zero)
            {
                var lastError = Marshal.GetLastWin32Error();

                _allocateMemoryLabel.Text = @"Failed to allocate memory";
            }

            else
            {
                _allocateMemoryLabel.Text = @"Successfully allocated memory";
            }
            
               
            // Write memory in the process
            
            if (WriteProcessMemory(processHandle, memory, Encoding.Default.GetBytes(dllPath), (uint)(dllPath.Length + 1), 0) == 0)
            {
                var lastError = Marshal.GetLastWin32Error();

                _writeMemoryLabel.Text = @"Failed to write memory";
            }

            else
            {
                _writeMemoryLabel.Text = @"Successfully wrote memory";
            }

            // Create a thread to call LoadLibraryA in the process
            
            if (CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryA, memory, 0, IntPtr.Zero) == IntPtr.Zero)
            {
                var lastError = Marshal.GetLastWin32Error();

                _createRemoteThreadLabel.Text = @"Failed to create remote thread";
            }

            else
            {
                _createRemoteThreadLabel.Text = @"Successfully created remote thread";
            }
        }
    }
}
