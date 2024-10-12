using System;
using System.Collections.Generic;

// Програма, де створюється методи для побудування будинку
namespace Paterns_arch_4_builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            HouseDirector director = new HouseDirector();
            HouseBuilder builder = new ModernHouseBuilder();

            director.SetBuilder(builder);
            director.ConstructHouse();

            House house = builder.GetHouse();
            house.ShowDetails();
        }

    }
}