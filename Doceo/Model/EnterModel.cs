using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doceo.Model
{
    public class EnterModel
    {

        public class user 
        {
            string _login;
            string _password;
            public string login
            {
                get { return _login; }
                set { _login = value; }
            }
            public string password
            {
                get { return _password; }
                set { _password = value; }
            }
        }

        internal int CheckUser(string login, string password)
        {
            return 1;
        }
    }
}
