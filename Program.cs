namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int First, second, X, Y, sum;
            Console.WriteLine("Enter the first");
            First = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second");
            second = int.Parse(Console.ReadLine());
            for (X = First; X <= second; X++)
            {
                Y = 1;
                sum = 0;
                while (Y < X)
                {
                    if (X % Y == 0)
                        sum = sum + Y;
                    Y++;
                }
                if (sum == X && X != 0)

                    Console.WriteLine("{0}", X);
            }
        }
    }
}