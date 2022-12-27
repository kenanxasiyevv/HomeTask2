namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil et: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Eded nece reqemlidir? : ");
            int a = int.Parse(Console.ReadLine());
            int r; int sum = 0;
            while (number != 0)
            {
                r = number % 10;
                number = number / 10;

                sum += a * r;
                a--;


            }
            Console.WriteLine(sum);
        }
    }
}