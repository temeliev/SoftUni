using System;
using System.Collections.Generic;

//Being a nerd means writing programs about night clubs instead of actually going to ones.
//Spiro is a nerd and he decided to summarize some info about the most popular night clubs around the world. 
//He's come up with the following structure – he'll summarize the data by city, each city will have a list of venues and each venue will have a list of performers. 
//Help him finish the program, so he can stop staring at the computer screen and go get himself a cold beer.
//You'll receive the input from the console. There will be an arbitrary number of lines until you receive the string "END". 
//Each line will contain data in format: "city;venue;performer". 
//If either city, venue or performer don't exist yet in the database, add them. 
//If either the city and/or venue exist, update their info. 
//Cities should remain in the order in which they have been received, venues should be sorted alphabetically and performers should by unique (per venue) and also sorted alphabetically.
//Print the data by listing the cities and for each city its venues (on a new line starting with "->") and performers (separated by comma and space). 
//Check the examples to get the idea. And grab a beer when you're done, you deserve it. Spiro is buying.

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> clubsInfo = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
         
        string command = "";
        while (command != "END")
        {
            string[] input = Console.ReadLine().Split(';');
            if (input[0] == "END")
            {
                command = "END";
            }
            else
            {
                if (!clubsInfo.ContainsKey(input[0]))
                {
                    clubsInfo[input[0]] = new SortedDictionary<string, SortedSet<string>>();
                    clubsInfo[input[0]].Add(input[1], new SortedSet<string>());
                    clubsInfo[input[0]][input[1]].Add(input[2]);
                }
                else
                {
                    if (!clubsInfo[input[0]].ContainsKey(input[1]))
                    {
                        clubsInfo[input[0]].Add(input[1], new SortedSet<string>());
                        clubsInfo[input[0]][input[1]].Add(input[2]);
                    }
                    else
                    {
                        clubsInfo[input[0]][input[1]].Add(input[2]);
                    }
                }
            }

        }

        PrintInfo(clubsInfo);


    }

    private static void PrintInfo(Dictionary<string, SortedDictionary<string, SortedSet<string>>> info)
    {
        foreach (var city in info)
        {
            Console.WriteLine(city.Key);
            foreach (var venue in city.Value)
            {
                Console.Write("->{0}: ", venue.Key);
                string performers = "";
                foreach (var perf in venue.Value)
                {
                    performers += perf + ", ";
                }

                Console.WriteLine(performers.TrimEnd(new char[] { ' ', ',' }));
            }
        }
    }
}

