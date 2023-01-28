using System;

namespace Assignment1
{
    public class Album
    {

        private string albumName;
        private string artistName;
        private short numOfTracks;

        private void getAlbumInfo()
        {
            string temp;
            Console.WriteLine("Starting the Album Program!");
            Console.WriteLine("What is the nae of your favorite music album?");
            albumName = Console.ReadLine();
            Console.WriteLine("What is the name of the artist of "+albumName+"?");
            artistName = Console.ReadLine();
            Console.WriteLine("How many tracks does "+albumName+" have?");
            temp = Console.ReadLine();
            numOfTracks = Convert.ToSByte(temp);
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