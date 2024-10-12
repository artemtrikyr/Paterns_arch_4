using System;

namespace Paterns_arch_4_visitor
{
    public interface IFileVisitor
    {
        void Visit(TextFile textFile);
        void Visit(ImageFile imageFile);
    }
}

