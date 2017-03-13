using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
 
class TasksFromExtendedKurs
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var day = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                nums[i]++;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    nums[j]--;
                }
            }
            day++;
            var sum = 0;
            for (int j = 0; j < nums.Length; j++)
            {
                sum += nums[j];
            }
            if (sum > 0)
            {
                if (i == nums.Length - 1)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        if (nums[k] > 0)
                        {
                            nums[k]++;
                        }
                    }
                    i = -1;
                }
                continue;
            }
            else
            {
                Console.WriteLine("survived {0} days ({1} seasons)", day + 1, day / nums.Length);
                break;
            }
        }
        Console.WriteLine();
    }
}
