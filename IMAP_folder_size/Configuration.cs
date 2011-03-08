using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMAP_folder_size {
    internal class Configuration {

        private string _username;
        private string _password;
        private string _server;
        private int _port;
        
        public string Username {
            get { return _username; }
            set { _username = value; }
        }

        public string Password {
            get { return _password; }
            set { _password = value; }
        }

        public string Server {
            get { return _server; }
            set { _server = value; }
        }

        public int Port {
            get { return _port; }
            set { _port = value; }
        }
    }
}
