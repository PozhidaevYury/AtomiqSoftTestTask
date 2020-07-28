using System;
using System.Collections.Generic;

namespace TestTask
{
    public class Conditions
    {
        public Conditions()
        {
        }

        public static List<ColorObject> InitListOfColorObjects()
        {
            List<ColorObject> colorObjects = new List<ColorObject>();
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "С" });
            colorObjects.Add(new ColorObject() { Color = "С" });
            colorObjects.Add(new ColorObject() { Color = "З" });
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "С" });
            colorObjects.Add(new ColorObject() { Color = "З" });
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
            "З",
            "К",
            "С"
        };
            return colorRule;
    }

        public static ColorObjectsController GetColorObjectsController()
        {
            return new ColorObjectsController();
        }
    }
}
