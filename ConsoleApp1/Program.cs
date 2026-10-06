namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SmallPrice = 25;
            int LargePrice = 35;

            Console.WriteLine(" Enter the number of small carpet");
            int Small = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter the number of large carpet");
            int Large = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($" Price per small carpet:${SmallPrice}");
            Console.WriteLine($"Priceperlargecarpet:${LargePrice}");

            double Cost = (Small * SmallPrice) + (Large * LargePrice);

            Console.WriteLine($"Cost :{Cost}");

            Console.WriteLine("tax rate is 6 %");
            double Tax = Cost * 0.06;

            Console.WriteLine($"Tax :{Tax}$");

            double Total = Cost + Tax;

            Console.WriteLine($"Total :{Total}$");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
