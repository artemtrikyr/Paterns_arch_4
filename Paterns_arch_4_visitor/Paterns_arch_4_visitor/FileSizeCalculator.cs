using System;
namespace Paterns_arch_4_visitor
{
    public class FileSizeCalculator : IFileVisitor
    {
        public void Visit(TextFile textFile)
        {
            Console.WriteLine($"Розмір текстового файлу: {textFile.Content.Length}");
        }

        public void Visit(ImageFile imageFile)
        {
            Console.WriteLine($"Розмір зображення '{imageFile.FileName}': 2048 байт");
        }
    }
}

