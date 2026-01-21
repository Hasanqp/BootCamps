using System.Collections.Generic;

class Day04
{
    // Day 4: Inheritance, Polymorphism
    static void Main()         
    {
        Console.WriteLine("Problem 1");

        // Inheritance
        Person s1 = new Student("Hasan", 23, "A");
        s1.Display();


        Console.WriteLine("Problem 3");

        List<Animal> animals = new List<Animal>();

        animals.Add(new Dog());
        animals.Add(new Cat());
        animals.Add(new Dog());

        foreach (Animal animal in animals)
        {
            animal.Speak();
        }

        Console.WriteLine("Problem 2");
        // Polymorphism
        Animal a1 = new Dog();
        Animal a2 = new Cat();

        a1.Speak();
        a2.Speak();
    }
    #region Problem 1
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Student : Person
    {
        public string Grade;

        public Student(string name, int age, string grade)
            : base(name, age)
        {
            Grade = grade;
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Grade : " + Grade);
        }
    }
    #endregion
    #region Problem 2 & 3
    // Problem 2: Polymorphism
    // Animal defines a virtual method (Speak)
    // Dog and Cat override Speak with their own behavior
    // Objects are accessed through the base type (Animal)
    // The correct Speak() method is called at runtime (Polymorphism)
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog says: Woof");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat says: Meow");
        }
    }
    #endregion
}