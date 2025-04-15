using GitIntergration.Models;

namespace GitIntergration.Services
{
    public class RegisterService
    {
        public bool UserRegist(RegisterModel model)
        {
            UserModel userModel = new UserModel(model.Name,model.Account,model.Password,model.Address,"");
            userModel.Account = model.Account;
            userModel.Password = model.Password;
            return true;
        }
    }
}