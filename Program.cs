using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadZaVj1
{
    class KlasaC
    {
        int zbroj;
        double prosjek;
        public int Zbroj(int[]x)
        {
            for (int i = 0; i <5; i++)
            {
                zbroj = zbroj +x[i];
            }
                return zbroj;
        }
        public double Prosjek(int[]x)
        {
            prosjek=zbroj/x.Length;
            return prosjek;
        }
    }
    internal class Program
    {
       /* Definirajte klasu KlasaC sa sljedećim članicama:
• metoda
int Zbroj(int[]) koja će vratiti zbroj svih članova proslijeñenog niza.
double Prosjek(int[]) koja će vratiti prosječnu vrijednost svih članova
proslijeñenog niza.
Definirajte objekt tipa KlasaC, zatražite od korisnika da unese 5 cijelih brojeva koje spremite u
niz tipa int veličine 5 članova.Taj niz proslijedite metodama Zbroj i Prosjek koje ćete pozvati
za definirani objekt, te povratne vrijednosti spremite u lokalne varijable zbroj i prosjek.*/
        static void Main(string[] args)
        {
             int []x= new int[5];
            int zbroj;
            double prosjek;
            KlasaC klasaC = new KlasaC();
            Console.WriteLine("Unesi 5 cijelih brojeva:");
            for(int i = 0;i <5;i++)
            { x[i] = Convert.ToInt32(Console.ReadLine()); }
            zbroj = klasaC.Zbroj(x);
            prosjek = klasaC.Prosjek(x);
          Console.WriteLine(zbroj);
            Console.WriteLine(prosjek);
            Console.ReadKey();
            
        }
    }
}
