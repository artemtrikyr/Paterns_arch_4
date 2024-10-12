using System;
using System.Collections.Generic;

//Клас, який реалізує всі методи для побудови сучасного будинку
namespace Paterns_arch_4_builder
{
    public class ModernHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation()
        {
            house.Foundation = "Бетоний фундамент";
        }
        public override void BuildWalls()
        {
            house.Walls = "Деревʼяні стіни";
        }
        public override void BuildRoof()
        {
            house.Roof = "Плоский дах";
        }
        public override void BuildWindows()
        {
            house.Windows = "Великі вікна";
        }
        public override void BuildDoors()
        {
            house.Doors = "Металеві двері";
        }
        public override void BuildPipes()
        {
            house.Pipes = "Пластикові труби";
        }
    }
}

 