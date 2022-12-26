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
                squere += i.GetSquere();

                perimetr += i.GetPerimetr();

                Console.WriteLine("Sq : " + i.GetSquere());

                Console.WriteLine("Pr : " + i.GetPerimetr()); 
                
            }

            Console.WriteLine("\nSq total: " + string.Format("{0:f1}", squere));

            Console.WriteLine("\nPr total : " + string.Format("{0:f1}", perimetr)); 
        }
    }
}