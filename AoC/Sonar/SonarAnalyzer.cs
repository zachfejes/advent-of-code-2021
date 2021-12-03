using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;


namespace AoC.Sonar {

    public class SonarAnalyzer {

        public int FindNumberOfDepthIncreases(string pathToReportFile) {
            int[] depthArray = ParseReportToIntArray(pathToReportFile);
            int numberOfDepthIncreases = 0;

            for(int i = 1; i < depthArray.Length; i++) {
                if(depthArray[i] > depthArray[i - 1]) {
                    numberOfDepthIncreases++;
                }
            }

            return numberOfDepthIncreases;
        }

        public int[] ParseReportToIntArray(string pathToReportFile) {
            List<int> depthArray = new List<int>();

            foreach(string line in File.ReadLines(pathToReportFile)) {
                depthArray.Add(ParseLine(line));
            }

            return depthArray.ToArray<int>();
        }

        public int ParseLine(string line) {
            int parsedValue;

            try {
                parsedValue = int.Parse(line);
            }
            catch {
                throw new FormatException("Sonar Report does not conform to expected format.");
            }

            return parsedValue;
        }
        
    }
}