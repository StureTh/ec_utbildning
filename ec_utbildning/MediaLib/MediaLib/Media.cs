using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib
{
    class Media
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Publisher { get; set; }

        public Media(string name="",string genre="",int year=0,string publisher="")
        {
            this.Name = name;
            this.Genre = genre;
            this.Year = year;
            this.Publisher = publisher;
        }

        public void PrintMedia()
        {
            Console.WriteLine("Name: {0}, Genre: {1}, Year {2}, Publisher: {3}",Name,Genre,Year,Publisher);
        }
    }
}
