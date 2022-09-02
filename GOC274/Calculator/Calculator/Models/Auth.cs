using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class Auth : IAuth
    {
        public bool LogIn(string user, string password)
        {
            return user == "gopas" && password == "gopas";
        }
    }
}
