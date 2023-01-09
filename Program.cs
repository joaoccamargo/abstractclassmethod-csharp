using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;


namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Rectangle or Circle (r/c)?");
                char selectType = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                string selectColor = Console.ReadLine();
                if (selectType == 'r')
                {
                    Console.Write("Width: ");
                    double Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(Enum.Parse<Color>(selectColor), Width, Height));
                }
                else if (selectType == 'c')
                {
                    Console.Write("Radius: ");
                    double Radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(Enum.Parse<Color>(selectColor), Radius));
                }
            }
            Console.WriteLine();
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}