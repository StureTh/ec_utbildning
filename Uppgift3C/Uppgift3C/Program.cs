using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3C
{
    class Program
    {

        static void Main(string[] args)
        {
            string pName;
            double price;
            double quant;
            string food;

            Console.WriteLine("Enter product name:\n");
            pName = string.Format(Console.ReadLine());

            Console.WriteLine("Price on product?\n");
            price = int.Parse(Console.ReadLine());

            Console.WriteLine("How many do you want?\n");
            quant = int.Parse(Console.ReadLine());

            Console.WriteLine("Is it foodz? Yes/No\n");
            food = string.Format(Console.ReadLine());

            if (food == "yes")
            {
                price = price * 1.25;
                Console.WriteLine("The product you choosed is: {0}\nThe quantity you choosed is {1}\nThe total price is {2} with 25% in food tax",pName,quant,price*quant);
            }
            else
            {
                Console.WriteLine("The product you choosed is: {0}\nThe quantity you choosed is {1}\nThe total price is {2} with 0% in food tax",pName,quant,price*quant);

            }
            Console.ReadLine();

        }
    }
}
