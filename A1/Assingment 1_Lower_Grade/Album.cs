using System;

/* GRADE D: Album */

namespace A1_Lower_Grade
{
    public class Album
    {

        private string? albumName = null;
        private string? artistName = null;
        private ushort numOfTracks;

        private void getAlbumInfo()
        {
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine("What is the nae of your favorite music album?");
            albumName = Console.ReadLine();
            Console.WriteLine("What is the name of the artist of "+albumName+"?");
            artistName = Console.ReadLine();
            Console.WriteLine("How many tracks does "+albumName+" have?");
            numOfTracks = Convert.ToUInt16(Console.ReadLine());
        }

        private void displayAlbumInfo()
        {
            Console.WriteLine("\nAlbum Name: "+albumName);
            Console.WriteLine("Artist: "+artistName);
            Console.WriteLine("Number of Tracks: {0}",numOfTracks);
            Console.WriteLine("Enjoy listening!");
        }

        public void Start()
        {
            getAlbumInfo();

            displayAlbumInfo();
        }
    }

}