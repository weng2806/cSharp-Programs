using System;
namespace ConsoleApp1
{
    class Animal
    {
        public string name;
        public int age;
        public string sound;
        public string move;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void SetMakeSound(string sound)
        {
            this.sound = sound;
        }

        public virtual string GetMakeSound()
        {
            return this.sound;

        }
        public void SetMoveAnimal(string move)
        {
            this.move = move;
        }
        public virtual string GetMoveAnimal()
        {
            return this.move;
        }

        public virtual void makeSound()
        {
            Console.WriteLine("");
        }
        public virtual void makeMove()
        {
            Console.WriteLine("");
        }




        public void DisplayInfo(string name, int age)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Dog : Animal
    { 

        public override void makeSound()
        {
            Console.WriteLine("Bark!");
        }
        public override void makeMove()
        {
            Console.WriteLine("Run!");
        }
        public void Play()
        {
            Console.WriteLine("Dog plays fetch.");
        }
        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.name = name;
            this.age = age;

            DisplayInfo(this.name, this.age);
            Console.WriteLine("Breed: " + breed);
            makeSound();
            makeMove();
            Play();
        }
    }

    class Cat : Animal
    {

        public override void makeSound()
        {
            Console.WriteLine("Meow!");
        }
        public override void makeMove()
        {
            Console.WriteLine("Sneak!");
        }
        public void Play()
        {
            Console.WriteLine("Cat plays with a ball.");
        }
        public Cat(string name, int age, string color) : base(name, age)
        {
            this.name = name;
            this.age = age;

            Console.WriteLine("");
            DisplayInfo(this.name, this.age);
            Console.WriteLine("Color: " + color);
            makeSound();
            makeMove();
            Play();
        }
    }

    class Cow : Animal
    {

        public override void makeSound()
        {
            Console.WriteLine("Moo!");
        }
        public override void makeMove()
        {
            Console.WriteLine("Walk!");
        }
        public void Play()
        {
            Console.WriteLine("Cow doesn't play.");
        }
        public Cow(string name, int age, string milkAmount) : base(name, age)
        {
            this.name = name;
            this.age = age;

            Console.WriteLine("");
            DisplayInfo(this.name, this.age);
            Console.WriteLine("Milk Amount: " + milkAmount);
            makeSound();
            makeMove();
            Play();
        }
    }
    class Bird : Animal
    {

        public override void makeSound()
        {
            Console.WriteLine("Chirp!");
        }
        public override void makeMove()
        {
            Console.WriteLine("Fly!");
        }
        public void Play()
        {
            Console.WriteLine("Bird flaps its wings playfully.");
        }
        public Bird(string name, int age, string wingSpan) : base(name, age)
        {
            this.name = name;
            this.age = age;

            Console.WriteLine("");
            DisplayInfo(this.name, this.age);
            Console.WriteLine("Milk Amount: " + wingSpan);
            makeSound();
            makeMove();
            Play();
        }
    }
    class Lion : Animal
    {

        public override void makeSound()
        {
            Console.WriteLine("Roar!");
        }
        public override void makeMove()
        {
            Console.WriteLine("Pounce!");
        }
        public Lion(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;

            Console.WriteLine("");
            DisplayInfo(this.name, this.age);
            makeSound();
            makeMove();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myDog = new Dog("Aso", 2, "Bulldog");
            Animal myCat = new Cat("Pusa", 4, "Black");
            Animal myCow = new Cow("Kalabaw", 7, "20 Liters");
            Animal myBird = new Bird("Ibon", 8, "Malapad");
            Animal myLion = new Lion("Lion", 9);
        }
    }
}
