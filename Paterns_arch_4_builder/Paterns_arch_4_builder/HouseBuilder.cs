using System;
using System.Collections.Generic;
namespace Paterns_arch_4_builder
{
    //Будівельник. Абстрактний клас, який містить методи створення компонентів класів
    public abstract class HouseBuilder
    {
        protected House house;

        public House GetHouse()
        {
            return house;
        }

        public void CreateNewHouse()
        {
            house = new House();
        }

        public abstract void BuildFoundation();
        public abstract void BuildWalls();
        public abstract void BuildRoof();
        public abstract void BuildWindows();
        public abstract void BuildDoors();
        public abstract void BuildPipes();

    }
}

