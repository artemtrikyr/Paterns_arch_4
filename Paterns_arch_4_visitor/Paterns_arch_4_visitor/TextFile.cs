using System;
namespace Paterns_arch_4_visitor
{
    public class TextFile : IFile
    {
        public string Content { get; set; }

        public TextFile(string content)
        {
            Content = content;
        }

        public void Accept(IFileVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ImageFile : IFile
    {
        public string FileName { get; set; }

        public ImageFile(string fileName)
        {
            FileName = fileName;
        }

        public void Accept(IFileVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

