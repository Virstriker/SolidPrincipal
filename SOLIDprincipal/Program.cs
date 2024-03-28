using System.Threading.Tasks;
using System;
namespace SOLIDprincipal
{
    public class program { 
        public static void Main(String[] args)
        {
            SendEMail mail = new SendEMail();
            ReadDatabase re = new ReadDatabase();
            re.ReadDatabaseContent();
            DeleteData del = new DeleteData();
            del.SendMail += mail.Email;
            del.SendMail += re.WriteDatabaseContent;

            del.DeleteDataByName();
            //del.Display();

        }
    }
}