using System;
using System.Collections;

namespace Assignment_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");

            // hashtable part
            Hashtable concerts = new Hashtable();

            concerts.Add("The Phantom of the Opera", new Concert("The Phantom of the Opera", "Wolffintie 30", new DateTime(2020, 8, 7, 19, 0, 0), 80));
            concerts.Add("The Remix", new Concert("The Remix", "Ahventie 20", new DateTime(2020, 10, 3, 20, 0, 0), 20.5));
            concerts.Add("The Return of Headhunterz", new Concert("The Return of Headhunterz", "Ahventie 30", new DateTime(2020, 12, 23, 22, 0, 0), 20));
            concerts.Add("Colours Of The Night", new Concert("Colours Of The Night", "My Dinh Stadium", new DateTime(2020, 12, 24, 20, 0, 0), 40));
            concerts.Add("fx Tour", new Concert("fx Tour", "Hang Day Stadium", new DateTime(2020, 1, 23, 19, 0, 0), 10));

            foreach(DictionaryEntry concert in concerts)
            {
                Console.WriteLine("Key: " + concert.Key);
                Console.WriteLine();
                Console.WriteLine(concert.Value.ToString());
                Console.WriteLine();
            }

            // operation part
            Concert concert1 = (Concert)concerts["fx Tour"];
            Concert concert2 = (Concert)concerts["Colours Of The Night"];

            concert1++;
            Console.WriteLine(concert1.ToString());

            concert2--;
            Console.WriteLine(concert2.ToString());

            Console.WriteLine("fx Tour < Colours Of The Night? " + (concert1 < concert2));


        }
    }
}
