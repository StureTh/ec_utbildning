using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraUpp02
{
    class Filter
    {
        public string RemoveBlankSpace(string input)
        {
            string newInput="";
            for (int i = 0; i < input.Length; i++)// Räknar charsen i string arrayen "strängen"
            {
                if (input[i]!= ' ') //  k
                {

                    newInput = newInput + input[i];



                }
                
            }
            return newInput;


        }
    }
}
