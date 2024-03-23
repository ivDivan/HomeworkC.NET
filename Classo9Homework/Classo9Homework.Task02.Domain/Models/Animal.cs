using Classo9Homework.Task02.Domain.Enums;

namespace Classo9Homework.Task02.Domain.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public AnimalGender Gender { get; set; }

        public Animal(string name, string color, int age, AnimalGender gender)
        {
            if(string.IsNullOrEmpty(name) && string.IsNullOrEmpty(color)) 
            {
                throw new ArgumentNullException("Name and Color can't be null or empty");
            }

            Name = name;
            Color = color;
            Age = age;
            Gender = gender;
        }
    }
}
