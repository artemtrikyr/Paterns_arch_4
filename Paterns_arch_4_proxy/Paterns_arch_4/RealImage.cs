using System;
using System.Collections.Generic;

namespace Paterns_arch_4
{
    public class RealImage : IImage
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk(); // Імітація повільного завантаження файлу
        }

        private void LoadFromDisk()
        {
            Console.WriteLine($"Завантаження {_fileName} з диску..");
        }

        public void Display()
        {
            Console.Write($"Відображення {_fileName}");
        }
    }
}

