using System;

class TorrentPirateMarch2015
{
    static void Main()
    {
        //Download time = (download data)/(fixed speed)/(seconds)/(minutes) =
        //= 30000 / 2 / 60 / 60 = 4.1667 hours in the mall

        //Price for download = (download time)*(wife spending) =
        //= 4.1667*50 = 208.34lv

        //Number of movies downloaded = 
        //= (download data)/(movie size) = 30000/1500 = 20 movies

        //Cinema price = 
        //= (number of movies)*(cinema price) = 20*5lv = 100lv
        //Result on the console: cinema -> 100lv

        double d = double.Parse(Console.ReadLine());//30000 Download data d: how much megabytes in total Jack should download.
        double p = double.Parse(Console.ReadLine());//5 Price of cinema p: how much money would cost Jack to go to the cinema to watch one movie.
        double w = double.Parse(Console.ReadLine());//50 Wife spending w: how much money per hour does Jack’s wife spend.

        double downloadTime = (d / 2 / 60 / 60);
        double priceForDownload = (downloadTime * w);
        double numberOfMoviesDownloaded = (d / 1500);

        double cinemaPrice = (numberOfMoviesDownloaded * p);
        double mallPrice = (downloadTime * w);

        if (cinemaPrice < mallPrice)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaPrice);
        }
        else
        {
            Console.WriteLine("mall -> {0:F2}lv", mallPrice);
        }

    }
}
