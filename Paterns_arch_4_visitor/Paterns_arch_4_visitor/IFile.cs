using System;

namespace Paterns_arch_4_visitor
{
    public interface IFile
    {
        void Accept(IFileVisitor visitor);
    }
}

