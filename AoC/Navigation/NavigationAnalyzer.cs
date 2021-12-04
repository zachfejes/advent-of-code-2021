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
        
        public int[] CalculateNavPlanFinalPosition(string pathToCommandsFile) {
            NavCommand[] navCommands = ParseFileToNavCommandArray(pathToCommandsFile);
            int aim = 0;
            int[] position = new int[] { 0, 0 };

            for(int i = 0; i < navCommands.Length; i++) {
                switch(navCommands[i].direction) {
                    case "forward":
                        position[0] += navCommands[i].magnitude;
                        position[1] += aim*navCommands[i].magnitude;
                        break;
                    case "up":
                        aim -= navCommands[i].magnitude;
                        break;
                    case "down":
                        aim += navCommands[i].magnitude;
                        break;
                    default:
                        break;
                }
            }

            return position;
        }
        
        public int CalculateNavPlanTotalVectorProduct(string pathToCommandsFile) {
            NavCommand[] navCommands = ParseFileToNavCommandArray(pathToCommandsFile);
            int x = 0;
            int y = 0;

            for(int i = 0; i < navCommands.Length; i++) {
                switch(navCommands[i].direction) {
                    case "forward":
                        x += navCommands[i].magnitude;
                        break;
                    case "up":
                        y -= navCommands[i].magnitude;
                        break;
                    case "down":
                        y += navCommands[i].magnitude;
                        break;
                    default:
                        break;
                }
            }

            return x*y;
        }

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