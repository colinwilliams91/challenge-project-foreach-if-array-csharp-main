using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  --------------------
 * --- Desired Output ---
 * --- -------------- ---
 *  Dear Ms. Barros,
 *  As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.
 *
 *  Currently, you own 2,975,000.00 shares at a return of 12.75 %.
 *
 *  Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.
 *
 *  Here's a quick comparison:
 *
 *  Magic Yield         12.75 %   $55,000,000.00      
 *  Glorious Future     13.13 %   $63,000,000.00  
*/

namespace Starter
{
    class Finances
    {
        public string CustomerName { get; set; }
        public string CurrentProduct { get; set; }
        public int CurrentShares { get; set; }
        public decimal CurrentReturn { get; set; }
        public decimal CurrentProfit { get; set; }
        public string NewProduct { get; set; }
        public decimal NewReturn { get; set; }
        public decimal NewProfit { get; set; }
        public string ComparisonMessage { get; set; }
        
        public Finances(string customerName)
        {
            this.CustomerName = customerName;

            this.CurrentProduct = "Magic Yield";
            this.CurrentShares = 2975000;
            this.CurrentReturn = 0.1275m;
            this.CurrentProfit = 55000000.0m;

            this.NewProduct = "Glorious Future";
            this.NewReturn = 0.13125m;
            this.NewProfit = 63000000.0m;
        }

        public void PrintOut()
        {
            string greetings = $"Dear {this.CustomerName},\n";
            string pOne = $"As a customer of our {this.CurrentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";
            string pTwo = $"Currently, you own {this.CurrentShares} shares at a return of {this.CurrentReturn:P2}.\n\n";
            string pThree = $"Our new product, {this.NewProduct} offers a return of {this.NewReturn:P2}.  Given your current volume, your potential profit would be {this.NewProfit:C2}.\n\n";
            string pFour = $"Here's a quick comparison:\n\n";
            string currentValuesOne = this.CurrentProduct.PadRight(20);
            string currentValuesTwo = $"{this.CurrentReturn:P2}".PadRight(10);
            string currentValuesThree = $"{this.CurrentProfit:C2}\n";

            string newValuesOne = $"{this.NewProduct.PadRight(20)}";
            string newValuesTwo = $"{this.NewReturn:P2}".PadRight(10);
            string newValuesThree = $"{this.NewProfit:C2}\n";

            Console.WriteLine(greetings + pOne + pTwo + pThree + pFour + currentValuesOne + currentValuesTwo + currentValuesThree + newValuesOne + newValuesTwo + newValuesThree);
        }

    }
}
