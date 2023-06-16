using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question_2_Project_2
{
    class Accounts
    {
    

        public void menuePrint()
        {
            Console.WriteLine(@"
                            please press:
                               c for cheque
                               s for savings
                               x to exit        
                        ");

        }
        public void savings()
        {
            string output = "";
            const float interest = 0.04f;
            Console.Write("Enter minimum balance: ");          
            float minBalance = float.Parse(Console.ReadLine());
            
            Console.Write("Enter current balance of customer: ");
            float currentBalance = float.Parse(Console.ReadLine());
            
            if (currentBalance <= 100.00)
            {
                output += "Service charge of R50.00 must be paid."+"\n";
                currentBalance = currentBalance - 50.00f;
            }

            if (currentBalance >= minBalance)
            {
                output += "Interest = R" + (interest *currentBalance).ToString("0.00") + "\n";
                currentBalance = currentBalance + (currentBalance * interest);
            }

            output += "Final Balance = R" + (currentBalance).ToString("0.00") + "\n";

            Console.WriteLine(output);
        }


        public void cheque()
        {
            string output = "";
            
            Console.Write("Enter minimum balance: ");
            float minBalance = float.Parse(Console.ReadLine());
            

            Console.Write("Enter current balance of customer: ");
            float currentBalance = float.Parse(Console.ReadLine());
            

            if (currentBalance <= 100.00)
            {
                output += "Service charge of R125.00 must be paid." + "\n";
                currentBalance = currentBalance - 125.00f;
            }

            if (currentBalance > minBalance && currentBalance < (minBalance + 10000.00f))
            {
                const float interest = 0.03f;
                output += "Interest = R" + (interest * currentBalance).ToString("0.00") + "\n";
                currentBalance = currentBalance + (currentBalance * interest);
            }
            else
            {
                const float interest = 0.05f;
                output += "Interest = R" + (interest * currentBalance).ToString("0.00") + "\n";
                currentBalance = currentBalance + (currentBalance * interest);
            }

            output += "Final Balance = R" + (currentBalance).ToString("0.00") + "\n";

            Console.WriteLine(output);
        }



    }
}
