

namespace Class07Homework.Task01Domain.Models
{
    public class Shape
    {
        private string _name;
        private string _colour;
        private int[] _position;

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                    Console.WriteLine($"Name is: {_name}");
                }
                else
                {
                    throw new ArgumentException("Name must not be empty");
                }
            }
        }

        public string Colour
        {
            get { return _colour; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _colour = value;
                    Console.WriteLine($"Colour is: {_colour}");
                }
                else
                {
                    throw new ArgumentException("Colour must not be empty");
                }
            }
        }

        public int[] Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public void Move(Shape shape)
        {
            Console.WriteLine($"Shape's original position is: ({shape.Position[0]}, {shape.Position[1]})");
            shape.Position[0] += 5;
            shape.Position[1] += 5;
            Console.WriteLine($"Shape moved to new position: ({shape.Position[0]}, {shape.Position[1]})");
        }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area.");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }
    }
}
