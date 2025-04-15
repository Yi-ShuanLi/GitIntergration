using System;

namespace GitIntergration.Models
{
    public class RegisterModel
    {
        public String Account { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }


        public RegisterModel(String Name,String Account,String Password,String Address)
        {
            this.Name = Name;
            this.Address = Address;
            this.Account = Account;
            this.Password = Password;
        }
    }
}