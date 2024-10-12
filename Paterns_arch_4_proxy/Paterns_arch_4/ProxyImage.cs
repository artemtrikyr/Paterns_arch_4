using System;
using System.Collections.Generic;

namespace Paterns_arch_4
{
    public class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null) //Тільки при першому виклику завантажується псевдо фото, і вже при другому - завантажується повністсю
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.Display();
        }
    }
}

