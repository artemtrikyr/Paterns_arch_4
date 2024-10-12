using System;
using System.Collections.Generic;

namespace Paterns_arch_4_visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IFile textFile = new TextFile("Це текстовий файл");
            IFile imageFile = new ImageFile("image.png");

            IFileVisitor sizeCalculator = new FileSizeCalculator();

            textFile.Accept(sizeCalculator);
            imageFile.Accept(sizeCalculator);
        }
    }
}