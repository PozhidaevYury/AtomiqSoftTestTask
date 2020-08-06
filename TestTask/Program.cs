using System;
using TestTask.ui;

namespace TestTask
{
    class Program
    {
        private readonly UserInterface ui;
        private ColorObjectsController controller = new ColorObjectsController();

        private const string ADD_BLUE_OBJECT = "B";
        private const string ADD_RED_OBJECT = "R";
        private const string ADD_GREEN_OBJECT = "G";
        private const string VIEW_OBJECT_LIST = "V";
        private const string ADD_RULE = "P";
        private const string VIEW_COLOR_RULE = "M";
        private const string SORT_OBJECT_LIST = "S";
        private const string VIEW_MENU = "H";
        private const string QUIT = "Q";

        public Program(UserInterface ui)
        {
            this.ui = ui;
        }

        private void Run()
        {
            ui.WriteInstruction();

            while (true)
            {
                switch (ui.GetCommand())
                {
                    case ADD_BLUE_OBJECT:
                        controller.AddBlueObject();
                        ui.ShowBlueObjectAdded();
                        break;
                    case ADD_RED_OBJECT:
                        controller.AddRedObject();
                        ui.ShowRedObjectAdded();
                        break;
                    case ADD_GREEN_OBJECT:
                        controller.AddGreenObject();
                        ui.ShowGreenObjectAdded();
                        break;
                    case VIEW_OBJECT_LIST:
                        ui.ShowListOfObjects(controller.objectList);
                        break;
                    case ADD_RULE:
                        ui.ShowRuleDescription();
                        controller.AddColorRule();
                        ui.ShowRuleAdded(controller.colorRule);
                        break;
                    case VIEW_COLOR_RULE:
                        ui.ShowColorRule(controller.colorRule);
                        break;
                    case SORT_OBJECT_LIST:
                        controller.SortObjects();
                        break;
                    case VIEW_MENU:
                        ui.WriteInstruction();
                        break;
                    case QUIT:
                        return;
                }
            }

        }

        static void Main(string[] args)
        {
            Program program = new Program(new UserInterface());
            program.Run();         
        }
    }
}
