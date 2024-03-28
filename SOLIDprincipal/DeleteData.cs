using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprincipal
{
    public delegate void SendMail();
    public class DeleteData : Delete
    {
        public SendMail SendMail; 
        List<Person> list = ReadDatabase.list;
        string path;
        public DeleteData() { 
            path = @"C:\Users\Vinayak.Gohel\source\repos\SOLIDprincipal\SOLIDprincipal\RemovedData.txt";
        }
        public void Display()
        {
            foreach(Person l in list)
            {
                Console.WriteLine(l.Name + " " + l.Surname + " " + l.Age);
            }
        }
        public void DeleteDataByName()
        {
            Console.Write("Remove Name:");
            string name = Console.ReadLine();
            //StreamWriter writer = new StreamWriter(path);
            foreach (Person person in list)
            {
                if(person.Name == name)
                {
                    string s = string.Concat(person.Name, " ", person.Surname, " ", person.Age);
                    //writer.WriteLine(s);
                    File.AppendAllText(path, s);
                }
            }
            //writer.Close();
            list.RemoveAll(x => x.Name == name);
            SendMail();
        }
    }
}
