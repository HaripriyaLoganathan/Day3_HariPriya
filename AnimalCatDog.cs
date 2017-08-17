using System;
namespace AnimalCatDog
{
    class Animal
    {
       public string name;
       public int age;
        public void Display()
        {
            
        }
    }
    class Cats:Animal
    { 
        public Cats(string s,int a)
        {
            name = s;
            age = a;
        }
        public void Display()
        {
            Console.WriteLine("Name of the Animal is " + name);
            Console.WriteLine("Age of the Animal is {0} years", age);
        }

    }
    class Dog : Animal
    {
        public Dog(string s, int a)
        {
            name = s;
            age = a;
        }
        public void  Display()
        {
            Console.WriteLine("Name of the Animal is " + name);
            Console.WriteLine("Age of the Animal is {0} years", age);
        }
    }
    class Derived
    { 
        static void Main(string[] args)
        {
            Dog d = new Dog("puppy",4);
            Cats c = new Cats("micky",3);
            c.Display();
            d.Display();
            Console.Read();
        }
    }
}
