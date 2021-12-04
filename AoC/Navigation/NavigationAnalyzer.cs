namespace AoC.Navigation {

    public class NavigationAnalyzer {
        

        public string[] ParseCommandsToStringArray(string pathToCommandsFile) {
            List<string> commandsArray = new List<string>();

            foreach(string line in File.ReadLines(pathToCommandsFile)) {
                commandsArray.Add(line);
            }

            return commandsArray.ToArray<string>();
        }
        

    }

}