using System.ComponentModel;
using System.Threading.Channels;

namespace Feladatok
{
    internal class Program
    {
        // 5; 14; karnevál-tól le
        static int[] tomb = new int[5];
        static Random r = new Random();
        static void F05()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("Kérek egy számot: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine();
            for (int i = (tomb.Length) - 1; i >= 0; i--)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine();
            for (int i = 1; i < tomb.Length; i += 2)
            {
                Console.WriteLine(tomb[i]);
            }
            Console.WriteLine();
            int szam;
            Console.WriteLine("Kérek egy számot (1-5):");
            szam = (Convert.ToInt32(Console.ReadLine())) - 1;
            Console.WriteLine($"A kért szám: {tomb[szam]}");
        }
        static void F14()
        {
            Console.Write("Kérem a tömb hosszát: ");
            int hossz = Convert.ToInt32(Console.ReadLine());
            int[] szamok = new int[hossz];
            int a;
            int b;
            do
            {
                Console.Write("Kérem az alsó határt a számoknál: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kérem a felső határt a számoknál: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (a > b || a == b)
                {
                    Console.WriteLine("Nem jó megadás");
                }
            } while (a > b || a == b);
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = r.Next(a, b);
            }
            bool vege = true;
            do
            {
                Console.WriteLine("""
                    a - Növelés
                    b - Csökkentés
                    c - Szorzás
                    d - kilépés
                    """);
                Console.Write("Mit szeretne csinálni(a-b-c-d):");
                string dontes = Console.ReadLine();
                switch (dontes)
                {
                    case "a": Console.Write("Mennyivel szeretné növelni: "); int n = Convert.ToInt32(Console.ReadLine()); for (int i = 0; i < szamok.Length; i++) { szamok[i] += n; } break;
                    case "b": Console.Write("Mennyivel szeretné csökkenteni: "); int c = Convert.ToInt32(Console.ReadLine()); for (int i = 0; i < szamok.Length; i++) { szamok[i] -= c; } break;
                    case "c": Console.Write("Mennyivel szeretné szorozni: "); int s = Convert.ToInt32(Console.ReadLine()); for (int i = 0; i < szamok.Length; i++) { szamok[i] *= s; } break;
                    case "d": vege = false; break;
                    default: Console.WriteLine("Nem jó megadás"); break;
                }
            } while (vege);
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }





        }
        static void Karneval()
        {
            int[] jegyek = new int[100];
            string[] dijak = new string[5];
            int[] nyertesek = new int[5];
            for (int k = 0; k < jegyek.Length; k++)
            {
                jegyek[k] = k + 1;
            }
            for (int j = 0; j < dijak.Length; j++)
            {
                Console.Write($"Mi legyen a(z) {j + 1}. díj: ");
                dijak[j] = Console.ReadLine();
            }
            bool kesz = true;
            int i = 0;
            do
            {
                int x = r.Next(0, 101);
                bool benne = false;
                foreach (int j in nyertesek)
                {
                    if (j != x && !benne)
                    {
                        nyertesek[i] = x;
                        i++;
                        benne = true;
                    }
                }
                if (i == nyertesek.Length)
                {
                    kesz = false;
                }
            } while (kesz);
            for (int k = 0; k < dijak.Length; k++)
            {
                Console.WriteLine($"{dijak[k]} --- {nyertesek[k]}. sorszám");
            }

        }
        static void Main(string[] args)
        {
            //F05();
            //F14();
            Karneval();
        }
    }
}
