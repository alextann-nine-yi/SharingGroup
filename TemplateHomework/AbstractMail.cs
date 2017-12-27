using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateHomework
{
    abstract public class AbstractMail
    {
        private string _receiver;
        private string _title;

        public AbstractMail(string title, string receiver)
        {
            this._title = title;
            this._receiver = receiver;
        }

        /// <summary>
        /// 需要通知主管.
        /// </summary>
        /// <returns></returns>
        virtual protected bool NeedsNotifySupervisor()
        {
            // 預設不通知
            return false;
        }

        virtual protected void MakeMailTitle()
        {
            Console.WriteLine("標題:" + _title);
        }

        virtual protected void MakeMailReceiver()
        {
            Console.WriteLine("收件人:" + _receiver);
        }

        abstract protected void MakeMailBody();

        virtual protected void Send()
        {
            Console.WriteLine("寄信完成");
        }

        virtual protected void AddReceiverSupervisor()
        {
            _receiver += "xxx@gmail.com;";
        }

        /// <summary>
        /// 送信主流程.
        /// </summary>
        public void SendProcess()
        {
            this.MakeMailTitle();
            if (this.NeedsNotifySupervisor())
            {
                this.AddReceiverSupervisor();
            }
            this.MakeMailReceiver();
            this.MakeMailBody();
        }
    }
}
