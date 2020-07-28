using System;
using System.Collections.Generic;

namespace TestTask
{
    public class ColorObjectsController
    {
        public ColorObjectsController()
        {
            
        }

        private const string Green = "З";
        private const string Red = "К";
        private const string Blue = "С";

        public List<ColorObject> SortObjects(List<ColorObject> colorObjects, List<string> colorRule)
        {
            CheckInputData(colorObjects, colorRule);

            List<ColorObject> lightObjects = new List<ColorObject>();
            List<ColorObject> mediumObjects = new List<ColorObject>();
            List<ColorObject> hardObjects = new List<ColorObject>();
            
            foreach (ColorObject colorObject in colorObjects)
            {
                if (colorObject.Color.Equals(colorRule[0]))
                {
                    lightObjects.Add(colorObject);
                }
                else if (colorObject.Color.Equals(colorRule[1]))
                {
                    mediumObjects.Add(colorObject);
                }
                else if (colorObject.Color.Equals(colorRule[2]))
                {
                    hardObjects.Add(colorObject);
                }
            }
            
            lightObjects.AddRange(mediumObjects);
            lightObjects.AddRange(hardObjects);

            return lightObjects;
        }

        private void CheckInputData(List<ColorObject> colorObjects, List<string> colorRule)
        {
            colorRule.ForEach(color => {
                if (!(color.Contains(Green) || color.Contains(Blue) || color.Contains(Red)))
                    throw new Exception("Ivlalid color");
            });

            colorObjects.ForEach(colorObject => {
                if (!(colorObject.Color.Contains(Green)
                || colorObject.Color.Contains(Blue)
                || colorObject.Color.Contains(Red)))
                    throw new Exception("Invalid color");

            });

            if (colorObjects.Count == 0)
                throw new Exception("List of objects is empty");
        }
    }
}
