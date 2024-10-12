using System;

namespace Paterns_arch_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image1 = new ProxyImage("photo1.jpg");
            IImage image2 = new ProxyImage("photo2.jpg");

            // Завантажується лише при першому виклику
            image1.Display();  
            Console.WriteLine("");
            

            // Повторний виклик не завантажує зображення знову
            image1.Display();
            Console.WriteLine("");

            // Завантажується нове зображення
            image2.Display();
            Console.WriteLine("");

            // Повторно не завантажує нове зображення
            image2.Display();
            Console.WriteLine("");
        }
    }

}