

namespace Class07Homework.Task01Domain.Models
{
    public class Rectangle : Shape
    {
        public int SideA {  get; set; }
        public int SideB { get; set; }

        public override void GetArea()
        {
            Console.WriteLine($"Area of Rectangle is: {SideA * SideB}");
        }

        public override void GetPerimeter()
        {
            Console.WriteLine($"Perimeter of Rectangle is: {2 * (SideB + SideA)}");
        }
    }
}
