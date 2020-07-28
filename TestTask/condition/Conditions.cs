using System;
using System.Collections.Generic;

namespace TestTask
{
    public class Conditions
    {
        public Conditions()
        {
        }

        private const string Green = "З";
        private const string Red = "К";
        private const string Blue = "С";

        public static List<ColorObject> InitListOfColorObjects()
        {
            List<ColorObject> colorObjects = new List<ColorObject>();
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Blue });
            colorObjects.Add(new ColorObject() { Color = Blue });
            colorObjects.Add(new ColorObject() { Color = Green });
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Blue });
            colorObjects.Add(new ColorObject() { Color = Green });
            return colorObjects;
        }

        public static void WriteSortListOfColorObjects(List<ColorObject> colorObjects)
        {
            foreach (ColorObject colorObject in colorObjects)
            {
                Console.WriteLine(colorObject.Color);
            }
        }

        public static List<string> GetColorRule()
        {
            List<string> colorRule = new List<string>
        {
            Green,
            Red,
            Blue
        };
            return colorRule;
    }

        public static ColorObjectsController GetColorObjectsController()
        {
            return new ColorObjectsController();
        }
    }
}
