using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib
{
    class Movie:Media
    {
        public string Director { get; set; }

        public Movie(string name="",string genre="",int year=0,string publisher="",string director=""):base(name,genre,year,publisher)
        {
            this.Director = director;

        }

        public void PrintDirector()
        {
            Console.WriteLine("Director: {0}",Director);

        }
    }
}
