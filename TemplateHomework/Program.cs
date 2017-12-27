using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================通知信============================");
            AbstractMail notifyMail = new NotifyMail("通知信","alextann@nine-yi.com;");
            notifyMail.SendProcess();

            Console.WriteLine("========================警告信============================");
            AbstractMail errorMail = new ErrorMail("警告信", "alextann@nine-yi.com;");
            errorMail.SendProcess();

            Console.WriteLine("========================警告信2============================");
            AbstractMail errorMail2 = new ErrorMail("警告信2", "alextann@nine-yi.com;", true);
            errorMail2.SendProcess();

            Console.ReadLine();
        }
    }
}
