using System;
using System.IO;

namespace AoC.Navigation {

    public class NavCommand {
        public string direction { get; set; }
        public int magnitude { get; set; }

        public NavCommand(string _direction, int _magnitude) {
            this.direction = _direction;
            this.magnitude = _magnitude;
        }
    }

    public class NavigationAnalyzer {
        

        public NavCommand[] ParseFileToNavCommandArray(string pathToCommandsFile) {
            List<NavCommand> commandsArray = new List<NavCommand>();

            foreach(string line in File.ReadLines(pathToCommandsFile)) {
                NavCommand navCommand = ParseNavCommandString(line);
                commandsArray.Add(navCommand);
            }

            return commandsArray.ToArray<NavCommand>();
        }

        public NavCommand ParseNavCommandString(string commandString) {
            string[] splitString = commandString.Split(' ');
            string direction = splitString[0];
            int magnitude = int.Parse(splitString[1]);
            return new NavCommand(direction, magnitude);
        }
        

    }

}