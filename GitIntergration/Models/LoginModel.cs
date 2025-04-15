using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIntergration.Models
{
    class LoginModel
    {
        public String Account { get; set; }
        public String Password { get; set; }
        public LoginModel(String account,String password)
        {
            this.Account = account;
            this.Password = password;
        }
        public String ReturnPassword()
        {
            return "1qaz2wsx";
        }

    }
}
