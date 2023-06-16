using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2_Project_2
{
    class Program
    {
        enum accounts {

            saving=115,
            cheque=99,
            exit =120
        }
        static void Main(string[] args)
        {

            Accounts account = new Accounts();
            account.menuePrint();
            char input = char.Parse(Console.ReadLine().ToLower());

            while (input!='x')
            {
                
                accounts menue = (accounts)input;


                switch (menue)
                {
                    case accounts.saving:
                        account.savings();
                        break;
                    case accounts.cheque:
                        account.cheque();
                        break;
                    case accounts.exit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("wrong input please try again");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                account.menuePrint();
                input = char.Parse(Console.ReadLine().ToLower());

            }
        }
    }
}
