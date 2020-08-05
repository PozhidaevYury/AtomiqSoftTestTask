using System;
using System.Collections.Generic;

namespace TestTask.ui
{
    public class UserInterface
    {
        public UserInterface()
        {
        }

        public void WriteInstruction()
        {
            Console.WriteLine("To add blue object press \"B\" \n" +
                "To add red object press \"R\" \n" +
                "To add green object press \"G\" \n" +
                "To view list of objects press \"V\" \n" +
                "To set color sorting rule press \"P\" \n" +
                "To view color rule press \"M\" \n" +
                "To sort list of objects press \"S\" \n" +
                "To view instruction press \"H\" \n" +
                "To exit press \"Q\" \n");
        }

        public string GetCommand()
        {
            var command = Console.ReadLine();

            if (command.Equals(""))
            {
                Console.WriteLine("Press any command");
                return null;
            }

            return command[0].ToString().ToUpper();
        }

        public void ShowBlueObjectAdded()
        {
            Console.WriteLine("Blue object has been added");
        }

        public void ShowRedObjectAdded()
        {
            Console.WriteLine("Red object has been added");
        }

        public void ShowGreenObjectAdded()
        {
            Console.WriteLine("Green object has been added");
        }

        public void ShowRuleDescription()
        {
            Console.WriteLine("Three colors is available: red, blue, green. \n" +
                "Color that is entered first has highest order. \n" +
                "Color that is entered second has medium order. \n" +
                "Color that is entered third has lowest order. \n" +
                "For instantse: \n" +
                "Red - press enter \n" +
                "Green - press enter \n" +
                "Blue - press enter");
        }

        public void ShowListOfObjects(List<ColorObject> objectList)
        {

            if(objectList.Count == 0)
            {
                Console.WriteLine("List of object is empty");
                return;
            }

            objectList.ForEach(colorObject =>
            {
                Console.WriteLine(colorObject.Color);
            });

            Console.WriteLine("size: " + objectList.Count);
        }

        public void ShowColorRule(List<string> colorRule)
        {

            if(colorRule.Count == 0)
            {
                Console.WriteLine("Rule is empty");
                return;
            }

            colorRule.ForEach(color =>
            {
                Console.WriteLine(color);
            });

        }

        public void ShowSortDone()
        {
            Console.WriteLine("Sorting was done");
        }

        public void ShowRuleAdded(List<string> colorRule)
        {
            Console.WriteLine("Rule has been added:");

            foreach (String color in colorRule)
            {
                Console.Write(color + " ");
            }
        }
    }
}
