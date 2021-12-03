using System;
using AoC.Sonar;

namespace AoC {

    public static class Program {

        public static void Main() {

            SonarAnalyzer analyzer = new SonarAnalyzer();

            string depthReportPath = @"../../../../AoC.Test/AcceptanceTests/TestInutFiles/Day1AInputs.txt";

            int numberOfDepthIncreases = analyzer.FindNumberOfDepthIncreases(depthReportPath);

            
            Console.WriteLine("Number of Depth Increases in Report: " + numberOfDepthIncreases);
        }
    }
}