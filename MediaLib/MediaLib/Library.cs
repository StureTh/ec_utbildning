using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib
{
    class Library:Media
    {
        public List<Movie> movies = new List<Movie>();
        public List<Book> books = new List<Book>();
        public List<Music> albums = new List<Music>();
        public List<Music> TrackList = new List<Music>();   

        public Library(string name="",string genre="",int year=0,string publisher="",string director="", string albumTitle=""):base(name,genre,year,publisher)
        {
            
        }

        public void AddMovie(Movie newMovie)
        {
            movies.Add(newMovie);
        }

        public void PrintMovie()
        {
            foreach (Movie movie in movies)
            {
                movie.PrintMedia();
                movie.PrintDirector();
            }
        }

        public void AddBook(Book newBook)
        {
            books.Add(newBook);
        }

        public void PrintBook()
        {
            foreach (Book book in books)
            {
                book.PrintMedia();
                book.PrintBook();
            }
        }

        public void AddAlbum(Music newAlbum)
        {
            albums.Add(newAlbum);
        }

        public void PrintAlbum()
        {
            foreach (Music album in albums)
            {
                album.PrintMedia();
                album.PrintAlbum();
                
                
            }
        }
        public void AddTrack(Music newTrack)
        {
            TrackList.Add(newTrack);
        }

        public void PrintTrack()
        {
            foreach (Music track in TrackList)
            {
                track.PrintTrack();
            }
        }
    }
}
