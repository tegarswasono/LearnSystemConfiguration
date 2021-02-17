using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnSystemConfiguration.Models
{
    public class SystemConfiguration
    {
        public string PlayStopToken { set; get; }
        public EmailService EmailService { set; get; }
    }
    public class EmailService
    {
        public string Host { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string DefaultFrom { set; get; }
        public long Port { set; get; }
    }
}
