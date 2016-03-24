using System;

class BetterMusicProducer18October2015
{
    static void Main()
    {
        decimal albumsEurope = decimal.Parse(Console.ReadLine());//1.The number of albums sold in Europe
        decimal priceEuro = decimal.Parse(Console.ReadLine());//2.The price of an album in euro
        decimal albumsNorthAmerica = decimal.Parse(Console.ReadLine());//3.The number of albums sold in North America
        decimal priceDollars = decimal.Parse(Console.ReadLine());//4.The price of an album in dollars
        decimal albumsSouthAmerica = decimal.Parse(Console.ReadLine());//5.The number of albums sold in South America
        decimal pricePesos = decimal.Parse(Console.ReadLine());//6.Price of an album in pesos
        decimal concerts = decimal.Parse(Console.ReadLine());//7.The number of concerts during a tour
        decimal profitOneEuro = decimal.Parse(Console.ReadLine());//8.Profit from a single concert in euro

        decimal profitEurope = (albumsEurope * priceEuro * 1.94m);
        decimal profitNorthAmerica = (albumsNorthAmerica * priceDollars * 1.72m);
        decimal profitSouthAmerica = (albumsSouthAmerica * pricePesos * 0.0030053495221494m);

        decimal profitWithoutProducer = profitEurope + profitNorthAmerica + profitSouthAmerica;
        decimal profitProducer = ((profitEurope + profitNorthAmerica + profitSouthAmerica) * 0.35m);
        decimal forIncome = ((profitWithoutProducer - profitProducer) * 0.2m);
        decimal ourProfit = profitWithoutProducer - (profitProducer + forIncome);

        decimal concertsProfit = (concerts * profitOneEuro * 1.94m);

        if (concertsProfit > 100000)
        {
            concertsProfit = (concertsProfit - (concertsProfit * 0.15m));
        }

        if (ourProfit > concertsProfit)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", ourProfit);
        }
        else if (concertsProfit > ourProfit)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", concertsProfit);
        }
    }
}