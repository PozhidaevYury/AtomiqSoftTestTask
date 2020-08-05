using System;
using System.Collections.Generic;

namespace TestTask
{
    public class ColorObjectsController
    {

        public readonly List<ColorObject> objectList = new List<ColorObject>();
        public readonly List<string> colorRule = new List<string>();

        public ColorObjectsController()
        {
            
        }

        private const string Green = "Green";
        private const string Red = "Red";
        private const string Blue = "Blue";

        public void AddBlueObject()
        {
            objectList.Add(new ColorObject() { Color = Blue });
        }

        public void AddRedObject()
        {
            objectList.Add(new ColorObject() { Color = Red });
        }

        public void AddGreenObject()
        {
            objectList.Add(new ColorObject() { Color = Green });
        }

        public void AddColorRule()
        {
            colorRule.Clear();
            List<string> addedColors = new List<string>();

            for(int element = 0; element < 3; element++)
            {
                var rule = Console.ReadLine();

                if (!IsValidInputRule(rule, addedColors))
                {
                    while (true)
                    {
                        rule = Console.ReadLine();
                        if (IsValidInputRule(rule, addedColors))
                            break;
                    }
                }

                colorRule.Add(rule);
                addedColors.Add(rule);
                Console.WriteLine("Color has been added");
            }
        }

        private bool IsValidInputRule(string rule, List<string> addedColors)
        {
            if (!(rule.Equals(Green) || rule.Equals(Blue) || rule.Equals(Red)))
            {
                Console.WriteLine("Incorrect color. Try again.");
                return false;
            }

            if (addedColors.Contains(rule))
            {

                Console.WriteLine("This is color already in use");
                return false;
                
            }
            return true;  
        }

        public List<ColorObject> SortObjects()
        {
            CheckInputData(objectList, colorRule);

            if (colorRule.Count == 0)
            {
                Console.WriteLine("List of rule is empty. Add rule");
                return null;
            }

            List<ColorObject> lightObjects = new List<ColorObject>();
            List<ColorObject> mediumObjects = new List<ColorObject>();
            List<ColorObject> hardObjects = new List<ColorObject>();
            
            foreach (ColorObject colorObject in objectList)
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

            objectList.Clear();
            objectList.AddRange(lightObjects);
            objectList.AddRange(mediumObjects);
            objectList.AddRange(hardObjects);
            
            return objectList;
        }

        private void CheckInputData(List<ColorObject> colorObjects, List<string> colorRule)
        {
            colorRule.ForEach(color => {
                if (!(color.Equals(Green) || color.Equals(Blue) || color.Equals(Red)))
                    throw new Exception("Rule contains incorrect color");
            });

            colorObjects.ForEach(colorObject => {
                if (!(colorObject.Color.Equals(Green)
                || colorObject.Color.Equals(Blue)
                || colorObject.Color.Equals(Red)))
                    throw new Exception("Object contatins incorrect color");

            });

            if (colorObjects.Count == 0)
            {
                Console.WriteLine("List of object is empty. Add some objects");
                return;
            }
        }
    }
}
