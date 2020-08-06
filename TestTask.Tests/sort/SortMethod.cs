using System;
using System.Collections.Generic;
using System.IO;
using Xunit;


namespace TestTask.Tests
{
    public class SortMethod
    {
        public SortMethod()
        {
        }

        private const string Green = "Green";
        private const string Red = "Red";
        private const string Blue = "Blue";

        private const string Yellow = "Yellow";

        ColorObjectsController controller = new ColorObjectsController();
        private List<ColorObject> sortObjects = new List<ColorObject>();

        public SortMethod SetupObjects()
        {
            controller.objectList.Clear();

            controller.AddRedObject();
            controller.AddGreenObject();
            controller.AddBlueObject();
            controller.AddBlueObject();
            controller.AddBlueObject();
            controller.AddGreenObject();
            controller.AddGreenObject();
            controller.AddRedObject();
            controller.AddRedObject();

            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Blue });
            sortObjects.Add(new ColorObject() { Color = Blue });
            sortObjects.Add(new ColorObject() { Color = Blue });
            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });

            return this;
        }

        public SortMethod SetupWithBigList()
        {
            for (int i = 0; i < Int32.MaxValue / 1000; i++)
            {
                controller.AddRedObject();
                controller.AddGreenObject();
                controller.AddBlueObject();
            }

            List<ColorObject> blueObjects = new List<ColorObject>();
            List<ColorObject> redObjects = new List<ColorObject>();

            for (int i = 0; i < Int32.MaxValue / 1000; i++)
            {
                sortObjects.Add(new ColorObject() { Color = Green });
                blueObjects.Add(new ColorObject() { Color = Blue });
                redObjects.Add(new ColorObject() { Color = Red });
            }

            sortObjects.AddRange(blueObjects);
            sortObjects.AddRange(redObjects);

            return this;
        }

        public SortMethod SetupWithInvalidColors()
        {
            controller.AddRedObject();
            controller.objectList.Add(new ColorObject() { Color = Yellow });
            controller.AddGreenObject();

            return this;
        }

        public SortMethod SetupRule()
        {
            controller.colorRule.Clear();
            controller.colorRule.Add(Green);
            controller.colorRule.Add(Blue);
            controller.colorRule.Add(Red);
            return this;
        }

        public SortMethod SetupEmptyRule()
        {
            controller.colorRule.Clear();
            return this;
        }

        public SortMethod SetupInvalidRule()
        {
            controller.colorRule.Add(Yellow);
            controller.colorRule.Add(Blue);
            controller.colorRule.Add(Red);
            return this;
        }

        public SortMethod SetupRuleWithSameColors()
        {
            controller.colorRule.Add(Blue);
            controller.colorRule.Add(Blue);
            controller.colorRule.Add(Red);
            return this;
        }

        public SortMethod SetupWithTwoColors()
        {
            controller.AddRedObject();
            controller.AddRedObject();
            controller.AddRedObject();
            controller.AddGreenObject();
            controller.AddGreenObject();
            controller.AddGreenObject();

            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });

            return this;
        }

        public SortMethod SetupWithOneColor()
        {
            controller.AddRedObject();
            controller.AddRedObject();
            controller.AddRedObject();

            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });

            return this;
        }

        public SortMethod SetupWithEmptyList()
        {
            controller.objectList.Clear();
            return this;
        }

        public SortMethod Sort()
        {
            controller.SortObjects();
            return this;
        }

        public void SortEmptyList()
        {
            var Expected = "List of object is empty. Add some objects";

            var sw = new StringWriter();
            Console.SetOut(sw);
            controller.SortObjects();

            var Result = sw.ToString().Trim();
            Assert.Equal(Expected, Result);
        }

        public void SortWithEmptyRule()
        {
            var Expected = "List of rule is empty. Add rule";

            var sw = new StringWriter();
            Console.SetOut(sw);
            controller.SortObjects();

            var Result = sw.ToString().Trim();
            Assert.Equal(Expected, Result);
        }

        public void AssertExceptionSort()
        {
            Assert.Throws<Exception>(() => controller.SortObjects());
        }

        public void AssertSort()
        {
            Assert.Equal(controller.objectList, sortObjects);
        }
    }
}
