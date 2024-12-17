using System;

namespace NASL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Violin violin = new Violin("Violin", "String instrument", "Bowed", "Orchestral");
            violin.Show();
            violin.Desc();
            violin.History();
            violin.Sound();

            Trombone trombone = new Trombone("Trombone", "Brass instrument", "Slide", "Orchestral");
            trombone.Show();
            trombone.Desc();
            trombone.History();
            trombone.Sound();

            Ukulele ukulele = new Ukulele("Ukulele", "String instrument", "Plucked", "Folk");
            ukulele.Show();
            ukulele.Desc();
            ukulele.History();
            ukulele.Sound();

            Cello cello = new Cello("Cello", "String instrument", "Bowed", "Orchestral");
            cello.Show();
            cello.Desc();
            cello.History();
            cello.Sound();
        }
    }

    public class MusicalInstrument
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string PlayingTechnique { get; set; }
        public string Genre { get; set; }

        public MusicalInstrument(string name, string type, string playingTechnique, string genre)
        {
            Name = name;
            Type = type;
            PlayingTechnique = playingTechnique;
            Genre = genre;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Playing Technique: {PlayingTechnique}");
            Console.WriteLine($"Genre: {Genre}");
        }

        public void History()
        {
            Console.WriteLine($"History of {Name}");
        }

        public virtual void Sound()
        {
            Console.WriteLine($"The {Name} makes a sound");
        }
    }

    public class Violin : MusicalInstrument
    {
        public Violin(string name, string type, string playingTechnique, string genre)
            : base(name, type, playingTechnique, genre)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The Violin produces a beautiful sound");
        }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string type, string playingTechnique, string genre)
            : base(name, type, playingTechnique, genre)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The Trombone produces a deep and rich sound");
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string type, string playingTechnique, string genre)
            : base(name, type, playingTechnique, genre)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The Ukulele produces a cheerful and bright sound");
        }
    }

    public class Cello : MusicalInstrument
    {
        public Cello(string name, string type, string playingTechnique, string genre)
            : base(name, type, playingTechnique, genre)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The Cello produces a warm and resonant sound");
        }
    }
}
