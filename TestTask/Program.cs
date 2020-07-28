using System;
using System.Collections.Generic;
using static TestTask.Conditions;

namespace TestTask
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ColorObject> colorObjects = InitListOfColorObjects();

            colorObjects = GetColorObjectsController().SortObjects(colorObjects, GetColorRule());

            WriteSortListOfColorObjects(colorObjects);
        }
    }
}
