using System;
using System.Collections.Generic;
using Xunit;

namespace TestTask.Tests
{
    public class SortTest
    {
        public SortTest()
        {
        }

        private const string Green = "З";
        private const string Red = "К";
        private const string Blue = "С";

        private const string Yellow = "Y";

        public List<ColorObject> colorObjects = new List<ColorObject>();
        public List<string> colorRule = new List<string>(3);
        public List<ColorObject> sortObjects = new List<ColorObject>();

        public SortTest Setup()
        {
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Green });
            colorObjects.Add(new ColorObject() { Color = Green });
            colorObjects.Add(new ColorObject() { Color = Green });
            colorObjects.Add(new ColorObject() { Color = Blue });
            colorObjects.Add(new ColorObject() { Color = Blue });
            colorObjects.Add(new ColorObject() { Color = Blue });

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

        public SortTest SetupWithInvalidColors()
        {
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Yellow });
            colorObjects.Add(new ColorObject() { Color = Green });
            colorObjects.Add(new ColorObject() { Color = Blue });

            return this;
        }

        public SortTest SetupRule()
        {
            colorRule.Add(Green);
            colorRule.Add(Blue);
            colorRule.Add(Red);
            return this;
        }

        public SortTest SetupInvalidRule()
        {
            colorRule.Add("J");
            colorRule.Add(Blue);
            colorRule.Add("");
            return this;
        }

        public SortTest SetupWithTwoColors()
        {
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Green });
            colorObjects.Add(new ColorObject() { Color = Green });
            colorObjects.Add(new ColorObject() { Color = Green });

            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Green });
            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });

            return this;
        }

        public SortTest SetupWithOneColor()
        {
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Red });
            colorObjects.Add(new ColorObject() { Color = Red });

            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });
            sortObjects.Add(new ColorObject() { Color = Red });

            return this;
        }

        public SortTest SetupWithEmptyList()
        {
            List<ColorObject> colorObjects = new List<ColorObject>();
            return this;
        }

        public SortTest Sort()
        {
            ColorObjectsController controller = new ColorObjectsController();
            colorObjects = controller.SortObjects(colorObjects, colorRule);
            return this;
        }

        public void AssertException()
        {
            ColorObjectsController controller = new ColorObjectsController();
            Assert.Throws<Exception>(() => controller.SortObjects(colorObjects, colorRule));
        }

        public void AssertObjects()
        {
            Assert.Equal(colorObjects.ToString(), sortObjects.ToString());
        }
    }
}
