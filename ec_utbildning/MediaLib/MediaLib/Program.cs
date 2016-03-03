using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Library libInfo = new Library();
            

            Movie movie1 = new Movie("StarWars","Sci-fi",2015,"Lucas Arts","George Lucas");
            Movie movie2 = new Movie("Ta2 Tog 3 - Kände för att slåss","Humor",2016,"Thuren INC","Sture Thuren");

            Book book1 = new Book("Human Harbour", "Horror", 1980, "Sony", "John Lindqvist", 242304230);
            Book book2 = new Book("GameOfThrones","Fantasy",2006,"Thrones Company","Nils Nilsson",34234234);

            Music album1 = new Music("Pink Floyd","Psy",1960,"Eggman","Dark Side of the Moon");
            Music album2 = new Music("Beatles","60's Rock",1960,"Golden Records","Strawberry Fields Forever");

            Music track1 = new Music("Bark at the moon");
            Music track2 = new Music("Yellow SubMarine");

            libInfo.AddMovie(movie1);
            libInfo.AddMovie(movie2);
            libInfo.PrintMovie();
            Console.ReadLine();
            libInfo.AddBook(book1);
            libInfo.AddBook(book2);
            libInfo.PrintBook();
            Console.ReadLine();
            libInfo.AddAlbum(album1);
            libInfo.AddTrack(track1);
            libInfo.AddAlbum(album2);
            libInfo.PrintAlbum();
            libInfo.PrintTrack();
            Console.ReadLine();

        }
    }
}
