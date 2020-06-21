using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Interop.Outlook;

namespace EskaleringsappV2CS
{
    public class Inform
    {
        public Inform()
        {

        }

/*        private string incident;
        private string icd;
        private int pri;
        private string slm;
        private string customer;*/
        private string fimemail = "fim.norway@evry.com";
/*        private string informEmail;*/

        virtual public void sendEmail(string customer, string slm, int pri, string incident, string icd, string informEmail)
        {
            Outlook.Application outlook = new Outlook.Application();
            Outlook.MailItem mailitem = outlook.CreateItem(Outlook.OlItemType.olMailItem);

            mailitem.SentOnBehalfOfName = this.fimemail;
            mailitem.To = informEmail;
            mailitem.CC = slm;

            mailitem.Subject = "P" + pri + " - " + incident + " - " + icd + " - " + customer;
        }
    }
}
