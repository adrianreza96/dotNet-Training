using System;

namespace assignment4
{

    public abstract class CityBaseClass
    {
        public CityBaseClass()
        {

        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my city!");
        }
    }

    class CityDerivedClass : CityBaseClass
    {
        public CityDerivedClass()
        {
            Console.WriteLine("Child class");
        }

        public new void WelcomeMessage()
        {
            Console.WriteLine("This is my city!");
        }
    }

    class InheritanceOverride
    {
        static void Main(string[] args)
        {
            CityDerivedClass cd = new CityDerivedClass();
            cd.WelcomeMessage();
        }
    }


}
