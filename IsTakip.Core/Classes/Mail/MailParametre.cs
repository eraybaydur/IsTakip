using IsTakip.Core.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Classes.Mail
{
    public class MailParametre : BaseObject
    {
        public string SenderName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SmtpAdres { get; set; }
        public int SmtpPort { get; set; }
        public bool SSLKullan { get; set; }
    }
}
