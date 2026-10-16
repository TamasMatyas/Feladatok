namespace Feladatok
{
    internal class Program
    {
        // 5; 14; karnevál
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
        static void Main(string[] args)
        {
            F05();
        }
    }
}
