using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLib
{
    class Music:Media
    {
       
        public string AlbumTitle { get; set; }
        public string Track { get; set; }

        public Music(string name="",string genre="",int year=0,string publisher="",string albumTitle= "",string track=""):base(name,genre,year,publisher)
        {
            this.AlbumTitle = albumTitle;
            this.Track = track;

        }

        

        public void PrintAlbum()
        {
            
            Console.WriteLine("Album: {0}",AlbumTitle);
            
        }

        public void PrintTrack()
        {
            Console.WriteLine("Track: 01: {0}\nTrack 02: {0}",Track);
        }

    }
}
