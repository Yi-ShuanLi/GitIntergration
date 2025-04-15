using System;

namespace GitIntergration.Models
{
    public class UserModel
    {
        public String Name { get; set; }
        public String Account { get; set; }
        public String Password { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }

        public UserModel(string name, string account, string password, string address, string phone)
        {
            Name = name;
            Account = account;
            Password = password;
            Address = address;
            Phone = phone;
        }
    }
}