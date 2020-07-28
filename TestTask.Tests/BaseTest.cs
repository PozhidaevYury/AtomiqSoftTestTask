using System;
using System.Collections.Generic;
using Xunit;

namespace TestTask.Tests
{
    public class BaseTest
    {
        public BaseTest()
        {
        }

        public List<ColorObject> colorObjects = new List<ColorObject>();
        public List<string> colorRule = new List<string>(3);
        public List<ColorObject> sortObjects = new List<ColorObject>();

        public BaseTest Setup()
        {
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "З" });
            colorObjects.Add(new ColorObject() { Color = "З" });
            colorObjects.Add(new ColorObject() { Color = "З" });
            colorObjects.Add(new ColorObject() { Color = "С" });
            colorObjects.Add(new ColorObject() { Color = "С" });
            colorObjects.Add(new ColorObject() { Color = "С" });

            sortObjects.Add(new ColorObject() { Color = "З" });
            sortObjects.Add(new ColorObject() { Color = "З" });
            sortObjects.Add(new ColorObject() { Color = "З" });
            sortObjects.Add(new ColorObject() { Color = "С" });
            sortObjects.Add(new ColorObject() { Color = "С" });
            sortObjects.Add(new ColorObject() { Color = "С" });
            sortObjects.Add(new ColorObject() { Color = "К" });
            sortObjects.Add(new ColorObject() { Color = "К" });
            sortObjects.Add(new ColorObject() { Color = "К" });

            return this;
        }

        public BaseTest SetupWithInvalidColors()
        {
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "L" });
            colorObjects.Add(new ColorObject() { Color = "З" });
            colorObjects.Add(new ColorObject() { Color = "С" });

            return this;
        }

        public BaseTest SetupRule()
        {
            colorRule.Add("З");
            colorRule.Add("С");
            colorRule.Add("К");
            return this;
        }

        public BaseTest SetupInvalidRule()
        {
            colorRule.Add("J");
            colorRule.Add("С");
            colorRule.Add("");
            return this;
        }

        public BaseTest SetupWithTwoColors()
        {
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "З" });
            colorObjects.Add(new ColorObject() { Color = "З" });
            colorObjects.Add(new ColorObject() { Color = "З" });

            sortObjects.Add(new ColorObject() { Color = "З" });
            sortObjects.Add(new ColorObject() { Color = "З" });
            sortObjects.Add(new ColorObject() { Color = "З" });
            sortObjects.Add(new ColorObject() { Color = "К" });
            sortObjects.Add(new ColorObject() { Color = "К" });
            sortObjects.Add(new ColorObject() { Color = "К" });

            return this;
        }

        public BaseTest SetupWithOneColor()
        {
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "К" });
            colorObjects.Add(new ColorObject() { Color = "К" });

            sortObjects.Add(new ColorObject() { Color = "К" });
            sortObjects.Add(new ColorObject() { Color = "К" });
            sortObjects.Add(new ColorObject() { Color = "К" });

            return this;
        }

        public BaseTest SetupWithEmptyList()
        {
            List<ColorObject> colorObjects = new List<ColorObject>();
            return this;
        }

        public BaseTest Sort()
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
