using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib
{
    class Book:Media
    {
        public string Author { get; set; }
        public int Isbn { get; set; }

        public Book(string name="",string genre="",int year=0,string publisher="",string author="",int isbn=0):base(name,genre,year,publisher)
        {
            this.Author = author;
            this.Isbn = isbn;
        }

        public void PrintBook()
        {
            Console.WriteLine("Author: {0}, ISBN: {1}",Author,Isbn);
        }
    }
}
