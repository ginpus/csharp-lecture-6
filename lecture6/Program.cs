using System;
using System.Collections;
using System.Collections.Generic;

namespace lecture6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Write a program which asks user how many numbers he wants to enter, then read those numbers from the console and find: sum, average, largest element, smallest element, reverse the array, sort the array in ascending order, sort the array in descending order. USE LIST

            /*Console.Write("Kiek skaiciu ivesite?: ");
            int kiekIvesti = Convert.ToInt32(Console.ReadLine());

            var skaiciai = new List<int>(kiekIvesti);
            // int[] initialArray = new int[kiekIvesti];
            for (int i = 0; i < kiekIvesti; i++)
            {
                Console.Write("Iveskite skaiciu: ");
                int skaicius = Convert.ToInt32(Console.ReadLine());
                skaiciai.Add(skaicius);
            }

            Console.WriteLine("Ivestas masyvas: ");
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius.ToString());
            }

            int sum = 0;
            foreach (var skaicius in skaiciai)
            {
                sum += skaicius;
            }

            Console.WriteLine($"Suma:{sum}");

            int max = 0;
            foreach (var skaicius in skaiciai)
            {
                if (max < skaicius)
                {
                    max = skaicius;
                }
            }

            Console.WriteLine($"Didziausias:{max}");

            int min = 0;
            foreach (var skaicius in skaiciai)
            {
                min += skaicius;
            }

            foreach (var skaicius in skaiciai)
            {
                if (min > skaicius)
                {
                    min = skaicius;
                }
            }

            Console.WriteLine($"Maziausuas:{min}");

            skaiciai.Reverse();

            Console.WriteLine("Apverstas masyvas: ");
            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius.ToString());
            }*/

            //--------------------------------

            /* var car = new Car();
             //ArrayList neturi tipo - gali priimti bet ka. LABAI RETAI NAUDOJAMAS!
             var items = new ArrayList();
             // Add tas pats kas JSe push
             items.Add("Name");
             items.Add(324568);
             items.Add(car);*/

            //----------------------------
            /*  //paprastas arrayaus sukurimas:
              var numbers = new int[] { };
              // listo sukyurimas. Skliauseliai reiskia, kad naudojamas konstruktorius
              var names = new List<string>();
              //pridėtis naudojant Add (su indexu berods neveikia)
              names.Add("John");
              names.Add("Ann");
              names.Add("Ann");
              names.Add("Paskutinis");
              //prideti naudojant insert. nurodoma indexo vieta
              names.Insert(0, "Pirmas");

              //isemimas konkrecios vertes
              names.Remove("Ann");

              //isemimas pagal indexa. names.Count paskaiciuoja, kiek nariu
              //istrina paskutini
              names.RemoveAt(names.Count - 1);
              //istrina pirma
              names.RemoveAt(0);

              foreach (var name in names)
              {
                  Console.WriteLine(name);
              }*/
            //-------------------------------------------------
            Console.WriteLine((int)WeekDays.Saturday);

            var weekDayInput = Console.ReadLine();
            //grazina Enum tipo kintamaji, kuris yra WeekDays tipo
            var isSuccessfull = Enum.TryParse(typeof(WeekDays), weekDayInput, true, out var weekDay);

            Console.WriteLine(weekDay);
        }
    }

    // apsirasyti konstantoms naudojam enum
    // jo enum galim pakonvertuoti ir kaip i int'a, o atspausdinti kaip stringa
    internal enum WeekDays
    {
        //po defaultu, pradeda nuo 0, bet galim pakeisti i kokia norim int verte
        Monday = 1,

        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    /*internal class Vehicle
    {
        public int Age;
    }

    // viskas, kas yra public po klase, is kurios paveldejama, nueina i paveldejancia klase
    internal class Car : Vehicle
    {
        public string Name = "Auto";
    }*/
}