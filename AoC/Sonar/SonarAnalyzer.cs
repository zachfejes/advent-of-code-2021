using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;


namespace AoC.Sonar {

    public class SonarAnalyzer {

        public int[] ParseReportToIntArray(string pathToReportFile) {

            List<int> depthArray = new List<int>();

            foreach(string line in File.ReadLines(pathToReportFile)) {
                depthArray.Add(int.Parse(line));
            }

            return depthArray.ToArray<int>();
        }
    }

}