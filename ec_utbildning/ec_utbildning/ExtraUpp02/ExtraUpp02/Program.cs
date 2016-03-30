using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUpp02
{
    class Program
    {
        #region EzWay
        //public static string RemoveBlankSpace()
        //{
        //    var input = "     Hello   S t u r e        !".Replace(" ", "");

        //    return input;
        //} 
        #endregion

        
        static void Main(string[] args)
        {
            #region EzWayMain
            //Console.WriteLine(RemoveBlankSpace().Trim());
            //Console.ReadKey(); 
            #endregion
            Filter filterFunction = new Filter();
            filterFunction.RemoveBlankSpace("Hello                                 S t u r e             !");
            Console.ReadKey();
        }
    }
}
