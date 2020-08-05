using System;
using System.Collections.Generic;

namespace TestTask
{
    public class ColorObject
    {
        public ColorObject()
        {
        }

        public string Color { get; set; }

        public override bool Equals(object obj)
        {
            return Color == ((ColorObject)obj).Color;
        }
    }
}
