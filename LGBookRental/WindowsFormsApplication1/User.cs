using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGBookRentals
{
    public class User
    {
        public string userId;
        private string password;
        public List<Order> orders;

        public User(string ID, string pswd)
        {
            this.userId = ID;
            this.password = pswd;
            orders = new List<Order>();
        }
    }
    
}
