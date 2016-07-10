using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using A;
using WMPLib;
using NETCONLib;

namespace MyLibrary.Functionality1
{
    class MyInterface : WMPLib.IWMPLibrary
    {
        public IWMPMediaCollection mediaCollection
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string name
        {
            get
            {
                return this.ToString();
            }
        }

        public WMPLibraryType type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool isIdentical(IWMPLibrary pIWMPLibrary)
        {
            throw new NotImplementedException();
        }
    }


    public class Display
    {
        public string DisplayMessage(string message)
        {            

            System.Windows.Forms.MessageBox.Show(message);
            ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
            c.f(message);
            return message + "nou";
        }
    }
}
