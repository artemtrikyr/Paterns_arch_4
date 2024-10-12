using System;
using System.Collections.Generic;

namespace Paterns_arch_4_builder
{
    // Клас має властивості: фундамент, стіни, дах, вікна і двері. 
    public class House
    {
        public string Foundation { get; set; }
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Windows { get; set; }
        public string Doors { get; set; }
        public string Pipes { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Будинок із такими компонентами");
            Console.WriteLine($"Фундамент: {Foundation}");
            Console.WriteLine($"Стіни: {Walls}");
            Console.WriteLine($"Дах: {Roof}");
            Console.WriteLine($"Вікна: {Windows}");
            Console.WriteLine($"Двері: {Doors}");
            //Дуже легко додавати нові компоненти - один із + будівельника
            Console.WriteLine($"Труби: {Pipes}");


        }
    }

    
}

