using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public abstract class GymPractice
    {
        protected string connectionString;

        public void ChangeClothes()
        {
            Console.WriteLine("Change clothes");
        }

        public void DrinkWater()
        {
            Console.WriteLine("Drink");
        }

        public abstract void GymExercise();

        public virtual void Shower()
        {
            Console.WriteLine("Shower");
        }

        public void Practice()
        {
            ChangeClothes();
            DrinkWater();
            GymExercise();
            Shower();
        }
    }
}
