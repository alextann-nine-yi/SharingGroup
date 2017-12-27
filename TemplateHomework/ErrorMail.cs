using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    public class ErrorMail : AbstractMail
    {
        private string _body;
        private bool _noticeSupervisor;

        public ErrorMail(string title, string receiver, bool noticeSupervisor = false) : base(title, receiver)
        {
            this._noticeSupervisor = noticeSupervisor;
        }

        protected override void MakeMailBody()
        {
            Console.WriteLine("開始寫信 - 內容");
            this._body = "*** 這是一封警告信 ***";
            Console.WriteLine("信件內容:" + this._body);
        }

        protected override bool NeedsNotifySupervisor()
        {
            return this._noticeSupervisor;
        }
    }
}
