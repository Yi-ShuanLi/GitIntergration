using GitIntergration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIntergration.Services
{
    class LoginService
    {
        public bool loginAct(String account,String password)
        {
            LoginModel loginModel = new LoginModel(account, password);
            String tempPassword = loginModel.ReturnPassword();
            if(tempPassword== loginModel.Password)
            {
                return true;
            }
            return false;
        }

    }
}
