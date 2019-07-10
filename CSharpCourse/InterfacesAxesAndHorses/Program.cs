using System;


namespace InterfacesAxesAndHorses
{
    class Program
    {
        static void Main(string[] args)
        {
            Greet(new Animal());
            //Greet(new Axe());
            //Greet(new Bread());
            Greet(new Horse());
            Greet(new Mouse());
            //Greet(new Sword());

            //PutInBag(new Animal());
            PutInBag(new Axe());
            PutInBag(new Bread());
            //PutInBag(new Horse());
            PutInBag(new Mouse());
            PutInBag(new Sword());

            //DoDamageWith(new Animal());
            DoDamageWith(new Axe());
            //DoDamageWith(new Bread());
            DoDamageWith(new Horse());
            //DoDamageWith(new Mouse());
            DoDamageWith(new Sword());
        }

        private static void DoDamageWith(IDangerous x)
        {
            x.DoDamage();
        }

        private static void PutInBag(IPackable x)
        {
            x.Pack();
        }

        private static void Greet(Animal animal)
        {
            animal.SayHello();
        }
    }

    interface IDangerous
    {
        void DoDamage();
    }
    interface IPackable
    {
        void Pack();
    }
    class Animal
    {
        public void SayHello()
        {
        }
    }
    class Mouse : Animal, IPackable
    {
        public void Pack()
        {

        }
    }
    class Horse : Animal, IDangerous
    {
        public void DoDamage()
        {
        }
    }
    class Axe : IPackable, IDangerous
    {
        public void DoDamage()
        {
        }

        public void Pack()
        {
        }
    }
    class Sword : IPackable, IDangerous
    {
        public void DoDamage()
        {
        }

        public void Pack()
        {
        }
    }
    class Bread : IPackable
    {
        public void Pack()
        {
        }
    }
}
