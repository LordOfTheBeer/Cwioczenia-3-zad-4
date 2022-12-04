namespace Zad_4_w_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double s = 0;

            for(n=0; n<=100; n++)
            {
                s += Math.Pow(-1, n ) / (2 * n + 1);
            }
            Console.WriteLine(s * 4);


            
        }
    }
}