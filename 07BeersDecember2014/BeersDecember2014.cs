using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BeersDecember2014
{
    static void Main()
    {
        string line = Console.ReadLine();

        int beerCount = 0;
        while (line != "End")
        {
            string[] data = line.Split(' ');
            int count = int.Parse(data[0]);
            string type = data[1];

            if (type == "beers")
            {
                beerCount = beerCount + count;
            }
            else if (type == "stacks")
            {
                beerCount = beerCount + count * 20;
            }

            line = Console.ReadLine();
        }

        int totalStacks = beerCount / 20;
        int leftBeers = beerCount % 20;
        Console.WriteLine("{0} stacks + {1} beers", totalStacks, leftBeers);

        //string[] data = Console.ReadLine().Split(' ');
        //int count = int.Parse(data[0]);
        //string type = data[1];
        //int beerCount = 0;

        //if (type == "beers")
        //{
        //    beerCount = beerCount + count;
        //}
        //else if (type == "stacks")
        //{
        //    beerCount = beerCount + count * 20;
        //}

        //int totalStacks = beerCount / 20;
        //int leftBeers = beerCount % 20;

        //Console.WriteLine("{0} stacks + {1} beers", totalStacks, leftBeers);
    }
}
