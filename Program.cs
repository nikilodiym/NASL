using System;

namespace NASL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kettle kettle = new Kettle("Electric Kettle", "Power: 1500W, Capacity: 1.7L");
            Microwave microwave = new Microwave("Microwave Oven", "Power: 1000W, Capacity: 20L");
            Car car = new Car("Sedan Car", "Engine: 2.0L, Horsepower: 150");
            Steamship steamship = new Steamship("Steamship", "Length: 100m, Capacity: 500 passengers");

            kettle.Show();
            kettle.Sound();
            kettle.Desc();

            microwave.Show();
            microwave.Sound();
            microwave.Desc();

            car.Show();
            car.Sound();
            car.Desc();

            steamship.Show();
            steamship.Sound();
            steamship.Desc();
        }
    }

    internal class Device
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }

        public Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public void Show()
        {
            Console.WriteLine($"Device: {Name}");
        }

        public void Sound()
        {
            Console.WriteLine($"Sound of {Name}: <sound>");
        }

        public void Desc()
        {
            Console.WriteLine($"Description of {Name}: {Characteristics}");
        }
    }

    internal class Kettle : Device
    {
        public Kettle(string name, string characteristics) : base(name, characteristics)
        {
        }
    }

    internal class Microwave : Device
    {
        public Microwave(string name, string characteristics) : base(name, characteristics)
        {
        }
    }

    internal class Car : Device
    {
        public Car(string name, string characteristics) : base(name, characteristics)
        {
        }
    }

    internal class Steamship : Device
    {
        public Steamship(string name, string characteristics) : base(name, characteristics)
        {
        }
    }
}
