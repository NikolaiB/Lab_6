namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squere = 0;
            double perimetr = 0;
            Figure[] figures = new Figure [5]
             {
                new Rectangle(20,20),

                new Triangle(3, 4, 5),

                new Rectangle(10, 10),

                new Circle(10),

                new Triangle(10,10,10),
            };

            foreach (var i in figures)
            {
                squere += i.Squere();
                perimetr += i.Perimetr();

                Console.WriteLine("Sq : " + i.Squere());
                Console.WriteLine("Pr : " + i.Perimetr()); 
                
            }

            Console.WriteLine("\nSq total: " + string.Format("{0:f1}", squere));
            Console.WriteLine("\nPr total : " + string.Format("{0:f1}", perimetr)); 
        }
    }
}