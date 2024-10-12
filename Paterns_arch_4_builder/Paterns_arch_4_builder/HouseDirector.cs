using System;
using System.Collections.Generic;

//клас що керує поетапним будівництвом самого будинку
namespace Paterns_arch_4_builder
{
    public class HouseDirector
    {
        private HouseBuilder builder;

        public void SetBuilder(HouseBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructHouse()
        {
            builder.CreateNewHouse();
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildWindows();
            builder.BuildDoors();
            builder.BuildPipes();
        }
    }
}

