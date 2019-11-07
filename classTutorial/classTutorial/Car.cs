using System;

namespace classTutorial
{
    public class Car
    {
        private string model;
        private string year;

        public Car(string model)
        {
            this.model = model;
        }

        public Car()
        {
            
        }
        private string Name { get; set; } = "No Name Entered";

        private void move()
        {
            Console.WriteLine("The car" + "" + " is moving...");
        }

        public void crash()
        {
            Console.WriteLine("The " + model + " car has crashed!!");
        }

        public void stop()
        {
            Console.WriteLine("The " + model + " car stopped!!");
        }
    }
}