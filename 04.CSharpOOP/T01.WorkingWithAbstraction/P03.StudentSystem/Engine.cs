using P03.StudentSystem.Entities;
using System;
using System.Xml;

namespace P03.StudentSystem
{
    public class Engine
    {
        //readonly -- означава че може да бъде сетнато само и единствено от конструктор и класа  не може да го променя
        private readonly StudentData studentData;

        private readonly IInputOutputProvider inputOutputProvider;

        public Engine(StudentData studentData, IInputOutputProvider inputOutputProvider)
        {
            this.studentData = studentData;
            this.inputOutputProvider = inputOutputProvider;
        }

        public void Process()
        {
            
            while (true)
            {
                var line = this.inputOutputProvider.GetInput();
 
                var command =Command.Parse(line);

                var end = this.ExecuteCommand(command);

                if (end)
                {
                    break;
                }
            }
        }

        private bool ExecuteCommand(Command command)
        {
            var name = command.Name;
            var arguments = command.Arguments;
            switch (name)
            {
                case "create":
                    this.studentData.Add(arguments[0], int.Parse(arguments[1]), double.Parse(arguments[2]));
                    break;
                case "show":
                    var details = this.studentData.GetDetails(arguments[0]);
                    this.inputOutputProvider.ShowOutput(details);
                    break;
                case "exit":
                    return true;
                    break;

            }
            return false;
        }
    }
}
