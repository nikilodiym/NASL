using System;

namespace NASL
{
    internal abstract class Worker
    {
        public abstract void Print();
    }

    internal class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("President");
        }
    }

    internal class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Security");
        }
    }

    internal class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager");
        }
    }

    internal class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Engineer");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Worker president = new President();
            president.Print();

            Worker security = new Security();
            security.Print();

            Worker manager = new Manager();
            manager.Print();

            Worker engineer = new Engineer();
            engineer.Print();
        }
    }
}
