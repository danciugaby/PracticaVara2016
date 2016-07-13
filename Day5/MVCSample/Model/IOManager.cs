using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Entities;
using log4net;
using System.Reflection;

namespace Model
{

    public class IOManager
    {
        string filepath;
        ILog logger;
        public IOManager()
        {
            logger =
                 LogManager.GetLogger(typeof(IOManager));



            var appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count == 0)
            {
                Console.WriteLine("AppSettings is empty.");
            }
            filepath = appSettings["path"];
            if (!File.Exists(filepath))
                File.Create(filepath);


        }
        public IOManager(string path)
        {
            logger =
                 LogManager.GetLogger(typeof(IOManager));



            filepath = path;
            if (!File.Exists(filepath))
                File.Create(filepath);


        }
        #region Methods
        public bool Insert(Employee e)
        {

            try
            {
                StreamWriter sr = new StreamWriter(filepath, true);
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

        public List<string> QueryAll()
        {
            List<string> list= new List<string>();
            try
            {
               StreamReader sr = new StreamReader(filepath);
                string line;
               while (( line = sr.ReadLine())!=null)
                {
                    list.Add(line);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.Message, ex);
                logger.Debug(ex.Message, ex);
                return new List<string>();
            }
            return list;
        }

        public bool DeleteAt(int index)
        {
            try
            {
                string[] lines = File.ReadAllLines(filepath);
                List<string> auxlist = new List<string>();
                for (int i = 0; i < lines.Count<string>(); i++)
                {
                    if (i != index)
                        auxlist.Add(lines[i]);
                }
                string[] newLines = auxlist.ToArray<string>();
                File.WriteAllLines(filepath, newLines);

            }
            catch (Exception ex)
            {
                logger.Fatal(ex.Message, ex);
                logger.Debug(ex.Message, ex);
                return false;
            }
            return true;
        }
        #endregion

    }
}
