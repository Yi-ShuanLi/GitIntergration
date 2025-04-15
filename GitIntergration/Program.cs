using GitIntergration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIntergration
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                LoginService loginService = new LoginService();
                Console.WriteLine("請輸入帳號：");
                string account = Console.ReadLine();
                Console.WriteLine("請輸入密碼：");
                string password = Console.ReadLine();
                bool temp = loginService.loginAct(account, password);
                if (temp == true)
                {
                    Console.WriteLine("登入成功!");
                    break;
                }
                else
                {
                    Console.WriteLine("登入失敗!");
                }
            }           
        }
    }
}
