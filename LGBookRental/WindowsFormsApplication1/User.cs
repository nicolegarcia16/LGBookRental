using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class User
    {
        public string userId;
        private string password;

        public User(string ID, string pswd)
        {
            this.userId = ID;
            this.password = pswd;
        }
    }
    
}
