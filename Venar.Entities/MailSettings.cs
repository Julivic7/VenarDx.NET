using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities
{
    public class MailSettings
    {
        public string Server { get; }
        public int Port { get;  }
        public string FromName { get;  }
        public string FromEmail { get;  }
        public string UserName { get;  }
        public string Password { get;  }

        public MailSettings(string server, int port, string fromName, string fromEmail, string userName, string password)
        {
            Server = server;
            Port = port;
            FromName = fromName;
            FromEmail = fromEmail;
            UserName = userName;
            Password = password;
        }
    }
}
