using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace InecDatabaseAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> votersName = new SortedSet<string>();

            votersName.Add("nas");
            votersName.Add("moh");
            votersName.Add("joy");
            votersName.Add("blessing");
            votersName.Add("peace");
            votersName.Add("jon");
            votersName.Add("kay");
            votersName.Add("berlin");
            votersName.Add("merlin");
            votersName.Add("zeddicus");
            votersName.Add("richard");
            votersName.Add("rahl");
            votersName.Add("morgana");
            votersName.Add("gaius");
            votersName.Add("arthur");
            votersName.Add("gerard");
            votersName.Add("lampard");
            votersName.Add("scholes");

            Console.WriteLine("enter voter name");
            string newName = Console.ReadLine();


            if (votersName.Contains(newName))
            {
                Console.WriteLine("Voter already exists");
            }
            else
            {
                votersName.Add(newName);
                Console.WriteLine("User successfully added");

            }
        }
    }
}
