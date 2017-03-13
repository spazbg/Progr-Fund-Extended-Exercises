using System;
using System.Linq;

namespace PowerPlants_6
{
    public class PowerPlants_6
    {
        public static void Main(string[] args)
        {
            var powerLevel = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            long daysInSeason = powerLevel.Length;
            long daysAlive = 0;
          
            
            for (long d = 0; d < daysInSeason; d++)
            {
                long sumPower = 0;
                for (long a = 0; a < powerLevel.Length; a++)
                {
                    sumPower += powerLevel[a];
                }
                if (sumPower > 0)
                {
                    daysAlive++;
                }
                else
                {
                    break;
                }
                //////////////////////

                for (long p = 0; p < powerLevel.Length; p++)
                {
                    if (d!=p && powerLevel[p]>0)
                    {
                        powerLevel[p] = powerLevel[p] - 1;
                    }
                }


                
                
                if (d== powerLevel.Length-1 && sumPower > 0)
                {
                    d = 0;
                    for (long i = 0; i < powerLevel.Length; i++)
                    {
                        if (powerLevel[i] > 0)
                        {
                            powerLevel[i]= powerLevel[i]+1;
                        }
                    }
                }

            }
            long seasons = (daysAlive -1) / daysInSeason;

            Console.WriteLine($"survived {daysAlive} days ({seasons} seasons)");
 
        }
    }
}
