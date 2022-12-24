namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nick = new Bookkeeper();

            Console.WriteLine("Your position is " + nick.PrintName());

            var victoria = new Director();

            Console.WriteLine("Your position is " + victoria.PrintName());

            var simon = new Employee();

            Console.WriteLine("Your position is " + simon.PrintName());



        }
    }
}