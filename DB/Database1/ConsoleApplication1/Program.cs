using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Configuration.Assemblies;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlServerCe;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetDataWithEF();
          
            using (SqlCeConnection conn =
          new SqlCeConnection(ConfigurationManager.ConnectionStrings["connstring"].ConnectionString))
            using (SqlCeCommand cmd = conn.CreateCommand())
            {
                conn.Open();
                //commands represent a query or a stored procedure       
                cmd.CommandText = "SELECT * FROM persons";
                string a = "dsadsa"               ;
                string q = "fdsfsaf";
     
                cmd.CommandText = "INSERT INTO [Persons] (Name, FirstName)  VALUES ('"+ a +"','"+q+"')";

                try
                {
                    object i = cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                }
                    using (SqlCeDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {//loop through the records one by one==
                     //0 gets the first columns data for this record
                     //as an INT
                     
                        int i = rd.GetInt32(0);
                        //gets the second column as a string

                        string s = rd.GetString(1);
                        string ss = rd.GetString(2);
                        //populate list in IoManager
                    }
                }
                conn.Close();
            }



        }

        private static void GetDataWithEF()
        {
            Entities entitiesObj = new Entities();
            List<Note> listaNote = entitiesObj.Notes.ToList();
            List<Person> listaPersoane = entitiesObj.Persons.ToList();
           // entitiesObj.Notes.RemoveRange(listaPersoane.First().Notes);
            entitiesObj.Persons.Remove(listaPersoane.First());
          

            entitiesObj.SaveChanges();

        }
    }
}
