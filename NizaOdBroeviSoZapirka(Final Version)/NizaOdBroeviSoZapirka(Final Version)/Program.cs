using System;
using System.Collections.Generic;
using System.Linq;

namespace NizaOdBroeviSoZapirka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi niza od broevi: ");
            string vneseniBroevi = Console.ReadLine();
            var listaNaBroevite = ParseTextNumbers(vneseniBroevi);
            PrintMaximum(listaNaBroevite);

        }
        public static void PrintMaximum(List<int> listaNaVneseniteBroevi)
        {
            Console.WriteLine($"\nNesortiranata lista na broevi e: {String.Join(',', listaNaVneseniteBroevi)}");
            listaNaVneseniteBroevi.Sort();
            Console.WriteLine($"\nSortiranata lista na broevi e: {String.Join(',', listaNaVneseniteBroevi)}");
            Console.WriteLine($"\nMaksimalniot broj od listata na vneseni broevi e: {listaNaVneseniteBroevi.Max()}");

        }
        public static List<int> ParseTextNumbers(string vneseniBroevi)
        {
            List<int> listaNaVneseniteBroevi = new List<int>();
            /*
             foreach(char character in vneseniBroevi)
             {
                 Console.WriteLine(character);
             }
            */
            string brojEkstrahiranOdNiza = " ";

            for (int i = 0; i < vneseniBroevi.Length; i++)
            {
                if (vneseniBroevi[i] != ',')
                {
                    brojEkstrahiranOdNiza += vneseniBroevi[i];
                }

                if (vneseniBroevi[i] == ',' || i == vneseniBroevi.Length - 1)
                {
                    try
                    {
                        listaNaVneseniteBroevi.Add(Convert.ToInt32(brojEkstrahiranOdNiza));
                        brojEkstrahiranOdNiza = "";
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Poradi nevaliden vnes ovoj podatok {brojEkstrahiranOdNiza} kje bide zanemaren.");
                    }
                    finally
                    {
                        brojEkstrahiranOdNiza = "";
                    }
                }
            }

            return listaNaVneseniteBroevi;
        }
    }
}
