using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entities;

namespace Model
{
    public class IOManager
    {
        string filepath;

        public IOManager()
        {

            var appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count == 0)
            {
                Console.WriteLine("AppSettings is empty.");
            }
            filepath = appSettings["path"];
            if (!File.Exists(filepath))
                File.Create(filepath);

            
        }

        public bool Insert(Employee e)
        {
           
            try
            {
                StreamWriter sr = new StreamWriter(filepath,true);
                sr.WriteLine(e);
               
                sr.Flush();
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
              
            }
            return true;

        }

    }
}
