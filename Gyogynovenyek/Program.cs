using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gyogynovenyek
{
    class Program
    {
        static List<Gyogynovenyek> novenyek = new List<Gyogynovenyek>();
        static Dictionary<string, int> reszek = new Dictionary<string, int>();

        static void Beolvasas()
        {
            StreamReader sr = new StreamReader("noveny.csv");
            while (! sr.EndOfStream)
            {
                novenyek.Add(new Gyogynovenyek(sr.ReadLine()));
            }
            sr.Close();
        }

        static void feladat1()
        {
            /*int db = 0;
            for (int i = 0; i < novenyek.Count; i++)
            {
                db++;
            }
            Console.WriteLine("1. Feladat: Növények száma: {0}",db);*/
            Console.WriteLine("1. Feladat: Növények száma: {0}", novenyek.Count);
        }

        static void feladat2()
        {
            Console.WriteLine("\n2. Feladat: Gyűjthető részek:");
            foreach (var n in novenyek)
            {
                if (!reszek.ContainsKey(n.Resz))
                {
                    reszek.Add(n.Resz, 0);
                }

            }

            foreach (var n in novenyek)
            {
                reszek[n.Resz]++;
            }

            foreach (var r in reszek)
            {
                Console.WriteLine($"{r.Key}: {r.Value}");
            }
        }

        static void feladat3()
        {
            int max = 0;
            foreach (var n in novenyek)
            {
                if (max<n.Idotartam)
                {
                    max = n.Idotartam;
                    
                }

            }
            Console.WriteLine($"\n3. Feladat: Legtöbb idő amíg kigyűjthető {max}");

            foreach (var n in novenyek)
            {
                if (n.Idotartam==max)
                {
                    Console.WriteLine("Növény(ek): \n{0}",n.Nev);
                }
            }
        }

        static void feladat4()
        {
            double sum = 0;
            double atlag = 0;
            foreach (var n in novenyek)
            {
                sum += n.Idotartam;
            }
            Console.WriteLine("\n4. Feladat: Átlagos gyűjthető időtartam: {0}", atlag = sum / novenyek.Count);
        }

        static void Main(string[] args)
        {
            Beolvasas();
            /*foreach (var n in novenyek)
            {
                Console.WriteLine($"{n.Nev}; {n.Resz}; {n.Kezd}; {n.Veg}; {n.Idotartam}");
            }*/
            feladat1();
            feladat2();
            feladat3();
            feladat4();


            Console.ReadKey();
        }
    }
}
