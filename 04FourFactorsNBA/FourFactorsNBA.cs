using System;

class FourFactorsNBA
{
    static void Main()
    {
//The Shooting Factor is measured using Effective Field Goal Percentage (eFG%). 
//eFG% = (Field Goals (FG) + 0.5 * 3-Point Field Goals (3P)) / Field Goals Attempted (FGA).

//The Turnover Factor is measured using Turnover Percentage (TOV%). 
//TOV% = Turnovers (TOV) / (FGA + 0.44 * Free Throw Attempts (FTA) + TOV).

//The Rebounding Factor for offense is measured in Offensive Rebounding Percentage (ORB%)
//ORB% = Offensive Rebounds (ORB) / (ORB + Opponent Defensive Rebounds (Opp DRB)).

//The Free Throw factor, or the 
//Free Throw Percentage (FT%) = Free Throws (FT) / FGA.

//eFG% = (3351 + 0.5 * 796) / 7018 = 0.534
//TOV% = 1125 / (7018 + 0.44 * 2080 + 1125) = 0.124
//ORB% = 967 / (967 + 2550) = 0.275
//FT% = 1556 / 7018 = 0.222

//input:
//3351 
//7018 
//796
//1125
//967
//2550
//1556
//2080

//output:
//eFG% 0.534
//TOV% 0.124
//ORB% 0.275
//FT% 0.222

        decimal fg = decimal.Parse(Console.ReadLine());//FG – Field Goals
        decimal fga = decimal.Parse(Console.ReadLine());//FGA – Field Goal Attempts
        decimal threep = decimal.Parse(Console.ReadLine());//3P – 3-Point Field Goals
        decimal tov = decimal.Parse(Console.ReadLine());//TOV – Turnovers
        decimal orb = decimal.Parse(Console.ReadLine());//ORB – Offensive Rebounds
        decimal oppdrb = decimal.Parse(Console.ReadLine());//Opp DRB – Opponent Defensive Rebounds
        decimal ft = decimal.Parse(Console.ReadLine());//FT – Free Throws
        decimal fta = decimal.Parse(Console.ReadLine());//FTA – Free Throw Attempts

        decimal efgResult = ((fg+ 0.5m * threep) / fga);//eFG%
        decimal tovResult = ((tov) / (fga + 0.44m * (fta) + tov));//TOV%
        decimal orbResult = ((orb) / (orb + (oppdrb))); //ORB%
        decimal ftResult = (ft / fga); //FT% 0.222

        Console.WriteLine("eFG% {0:F3}", efgResult);
        Console.WriteLine("TOV% {0:F3}", tovResult);
        Console.WriteLine("ORB% {0:F3}", orbResult);
        Console.WriteLine("FT% {0:F3}", ftResult);
    }
}