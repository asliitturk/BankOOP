using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Admin
{
    public class AdminInformation
    {
        public AdminInformation(string name, int password)
        {
            Name = name;
            Password = password;
        }
        public string Name { get; set; }
        public int Password { get; set; }
    }
}
