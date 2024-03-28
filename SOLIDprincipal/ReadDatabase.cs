using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprincipal
{
    public class ReadDatabase : DataBase
    {
        Person person;
        public static List<Person> list;
        string path;
        public ReadDatabase()
        {
            list = new List<Person>();
            path = @"C:\Users\Vinayak.Gohel\source\repos\SOLIDprincipal\SOLIDprincipal\Database.txt";
            person = new Person();
        }
        public void ReadDatabaseContent()
        {
            StreamReader reader = new StreamReader(path);
            string s = reader.ReadLine();
            while (s != null)
            {
                string[] s1 = s.Split(" ");
                list.Add(new Person{ Name = s1[0], Surname= s1[1],Age = Convert.ToInt32(s1[2])});
                //Console.WriteLine(list);
                s = reader.ReadLine();
            }
            reader.Close();

        }
        public void WriteDatabaseContent()
        {
            StreamWriter writer = new StreamWriter(path);
            foreach (Person person in list)
            {
                string s = string.Concat(person.Name," ",person.Surname," ",person.Age);
                writer.WriteLine(s);
            }
            writer.Close();
        }
    }
}
