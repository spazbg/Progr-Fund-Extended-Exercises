using System;
using System.Collections.Generic;
using System.Linq;

namespace TrackDownloader_2
    //You will receive a list of blacklisted words(on the same line, separated by one space). On the next lines, you will 
    //start receiving a list of filenames(as strings) until you receive the string “end”. Your task is to add the filenames 
    //to a list and sort them.Ignore the tracks which contain the text in the blacklist.
{
    public class TrackDownloader_2
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            List<string> blackListed = new List<string>(input
                .Split()
                .ToList()
                );

            var whitelist = new List<string>();

            var tracks = Console.ReadLine();
           
            while (!tracks.Equals("end"))
            {
                var blocked = false;

                foreach (var word in blackListed)
                {

                    if (tracks.Contains(word))
                    {
                        blocked = true;
                        break;
                    }
                   
                }
                if (!blocked)
                {
                    whitelist.Add(tracks);
                }

                tracks = Console.ReadLine();
            }

            whitelist.Sort();
            foreach (var item in whitelist)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
