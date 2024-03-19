using Class07Homework.Task01Domain.Models;

Circle circle = new Circle
{
    Name = "Mile",
    Colour = "Gan Green",
    Position = new int[] { 3, 7 },
    Radius = 10
};

circle.GetArea();
circle.GetPerimeter();
circle.Move(circle);

Rectangle rectangle = new Rectangle
{
    Name = "Ipce",
    Colour = "Ultraviolent",
    Position = new int[] { 8, 22 },
    SideA = 3,
    SideB = 4,
};

rectangle.GetArea();
rectangle.GetPerimeter();
rectangle.Move(rectangle);