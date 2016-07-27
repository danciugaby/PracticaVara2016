using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace InteroperabilitySample
{
    class Program
    {
        [DllImport("user32.dll")]
       
        static extern int MessageBox(IntPtr hwnd, string text, string caption, int type);

        [DllImport("...")]
        static extern int Foo([MarshalAs(UnmanagedType.LPStr)] string s);

        [DllImport("kernel32.dll")]
        static extern int GetWindowsDirectory(StringBuilder sb, int maxChars);

        [DllImport("NativeLibrary.dll",CharSet = CharSet.Unicode, 
            CallingConvention = CallingConvention.Cdecl)] 
        static extern int print_line(string str, int a);


static void Main(string[] args)
        {
          int i= print_line("ceva din c#",2);
            
                MessageBox(IntPtr.Zero, "Test Win", "Win", 0);

            StringBuilder s = new StringBuilder(256);
            GetWindowsDirectory(s, 256);
            Console.WriteLine(s);
        }
    }
}
