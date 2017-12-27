using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    public class NotifyMail : AbstractMail
    {
        private string _body;

        public NotifyMail(string title, string receiver) : base(title, receiver)
        {
        }

        protected override void MakeMailBody()
        {
            Console.WriteLine("開始寫信 - 內容");
            this._body = "這是一封通知信";
            Console.WriteLine("信件內容:" + this._body);
        }
    }
}
