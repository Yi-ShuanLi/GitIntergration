using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitIntergration.Models;
using GitIntergration.Services;

namespace GitIntergration
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowSystemInfo();
            RegisterModel user = GetUserRegistInfo();
            RegisterService service = new RegisterService();

            if (service.UserRegist(user))
            {
                Console.WriteLine("恭喜您，註冊成功！歡迎加入我們的大家庭！");
            }
            else
            {
                Console.WriteLine("很抱歉，註冊失敗了。請稍後再試，或聯繫我們的客服團隊以獲取協助。");
            }

            Console.WriteLine("註冊完成！接下來請重新輸入帳號與密碼進行登入。");

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
        
        
        static void ShowSystemInfo()
        {
            Console.WriteLine("歡迎來到 [XXX 註冊系統]！");
            Console.WriteLine("請依照指示完成註冊，讓我們開始吧！");
        }

        static RegisterModel GetUserRegistInfo()
        {
            Console.WriteLine("請輸入您的姓名：");
            string userName = Console.ReadLine();

            Console.WriteLine("接下來，請輸入您的帳號：");
            string account = Console.ReadLine();

            Console.WriteLine("請設置一個安全的密碼：");
            string password = Console.ReadLine();

            Console.WriteLine("最後，請輸入您的聯絡地址，讓我們方便與您保持聯繫：");
            string address = Console.ReadLine();

            RegisterModel user = new RegisterModel(userName, account, password, address);

            return user;
                    
        }
    }
}
