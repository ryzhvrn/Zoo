using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зоопарк
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Animal
    {
        public string Name { get; protected set; }
        public string Sex { get; protected set; }
        public string Sound { get; protected set; }

        public Animal(string name, string sex, string sound)
        {
            Name = name;
            Sex = sex;
            Sound = sound;
        }

        public virtual void GetSound()
        {
            Console.WriteLine("Звук, который я произношу: ");
        }
    }

    class Zoo
    {

    }

    class Aviary
    {

    }

    class Monkey : Animal
    {
        public Monkey(string name, string sex, string sound): base(name, sex, sound) { }

        public override void GetSound()
        {
            base.GetSound();
            Console.WriteLine("УуаАаауУаааа");
        }
    }

    class Giraffe : Animal
    {
        public Giraffe(string name, string sex, string sound) : base(name, sex, sound) { }

        public override void GetSound()
        {
            base.GetSound();
            Console.WriteLine("АааааАааа Хррр Хррррр");
        }
    }

    class Bear : Animal
    {
        public Bear(string name, string sex, string sound) : base(name, sex, sound) { }

        public override void GetSound()
        {
            base.GetSound();
            Console.WriteLine("АааааАааа Хррр Хррррр");
        }
    }

    class Duckbill : Animal
    {
        public Duckbill(string name, string sex, string sound) : base(name, sex, sound) { }

        public override void GetSound()
        {
            base.GetSound();
            Console.WriteLine("Уруруру уррруууууруу");
        }
    }

    class Otter : Animal
    {
        public Otter(string name, string sex, string sound) : base(name, sex, sound) { }

        public override void GetSound()
        {
            base.GetSound();
            Console.WriteLine("ИиииИиИиииии");
        }
    }
}
