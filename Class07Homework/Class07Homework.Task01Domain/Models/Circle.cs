

namespace Class07Homework.Task01Domain.Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override void GetArea()
        {
            Console.WriteLine($"Area of Circle: {Math.PI * Radius * Radius}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"Perimeter of Circle: {Math.PI * 2 * Radius}");
        }
    }
}
