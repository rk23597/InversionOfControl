using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvesionOfControl
{
    class Program
    {

        interface IFood {

            void Eat();
        }


        class Bread : IFood
        {
            public void Eat()
            {
                Console.WriteLine("I am eating Bread");
            }
        }

        class Meat : IFood
        {
            public void Eat()
            {
                Console.WriteLine("I am eating Meat");
            }
        }


        class FoodController {

            IFood _food;

            public FoodController(IFood food)
            {
                _food = food;       
            }

            public void StartEat() {

                if (_food != null)
                {

                    _food.Eat();
                }
                else
                    throw new Exception("No Food");

            }


        }

        static void Main(string[] args)
        {

            Bread bread = new Bread();
            Meat meat = new Meat();

            FoodController food1 = new FoodController(bread);
            food1.StartEat();


            FoodController food2 = new FoodController(meat);
            food2.StartEat();


            Console.ReadLine();
           

        }
    }
}
