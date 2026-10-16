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








        }
        static void Main(string[] args)
        {
            //F05();
            F14();
        }
    }
}
