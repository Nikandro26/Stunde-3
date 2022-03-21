using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hallo World");
            //Datetypengrössen
            //short a0 = short.MaxValue;
            //short a1 = short.MinValue;
            //ushort a2 = 2 * short.MaxValue+1;
            //int b = int.MaxValue;
            //long c = long.MaxValue;

            //Console.WriteLine("Short:" + a + "Int:" + b + "Long" + c);
            //Console.WriteLine("Short.min:" + a1 + "Short,max:" + a0 + " ushort:" + a2);


            //Verzweigungen(if-else Anweisung)
            int x = 5;
            int y = 1;

            if (x + y > 10)
            {
                Console.WriteLine("Das Ergebnis ist größer als 10");
            }
            else if (x + y == 10)
            {
                Console.WriteLine("Das Ergebnis ist genau 10.");
            }
            else
            {
                Console.WriteLine("Das ergebnis ist kleiner als 10.");
            }



            //Schleifen
            //Wiederholte Abläufe

            int zähler = 0;

            while (zähler < 10)
            {
                Console.WriteLine("Der Zähler ist: " + zähler);
           //While Schleife
           //zähler= zähler + 1);
           //zähler += 1;
                zähler++;
            }

            int zähler2 = 0;
            do
            {
                Console.WriteLine("Der Zähler ist: " + zähler2);
                zähler2++;
            } while (zähler2 < 10);

            for(int i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }

            //Beispiel:
            // Der Benutzer soll nach zwei ganzen zahlen befragt werden,
            // Falls die Summe größer als 125 ist, soll das Programm beendet werden
            //ansosten vorn beginen.
            int a, b;

            do
            {
                Console.WriteLine("Bitte nacheinander zwei ganze Zahlen eingeben");
                a = Convert.ToInt32(Console.ReadLine() );
                Console.Write("b=");
                b = Convert.ToInt32(Console.ReadLine() );
            } while (a + b < 125);


            //Der Benutzer soll nach einer Jahreszahl gefragt werden und es 
            //soll ausgegeben werden ob es sich um ein Schaltjahr handelt
        }

    }
}
