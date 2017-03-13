using System;
using System.Collections.Generic;
using System.Linq;


namespace FlipListSides_4
{
    public class FlipListSides_4
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var intList = new List<int>(input
                .Split()
                .Select(int.Parse)
                .ToList()
                );
            
            for (int i = 0; i < (intList.Count/2); i++)
            {
                if (i!=0)
                {
                    var temp = intList[i];
                    intList[i] = intList[(intList.Count) - i -1];
                    intList[(intList.Count) - i -1] = temp;
                }
                
            }

            Console.WriteLine(string.Join(" ", intList));
        }
    }
}
