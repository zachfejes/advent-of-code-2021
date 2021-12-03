using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;


namespace AoC.Sonar {

    public class SonarAnalyzer {


        public int FindNumberOfDepthIncreasesSmoothed(string pathToReportFile, int smoothingWindowSize) {
            int[] depthArray = ParseReportToIntArray(pathToReportFile);
            return FindNumberOfDepthIncreasesSmoothed(depthArray, smoothingWindowSize);
        }

        public int FindNumberOfDepthIncreasesSmoothed(int[] depthArray, int smoothingWindowSize) {
            List<int> smoothedDepthList = new List<int>();
            int[] smoothedDepthArray;

            for(int i = 0; i <= depthArray.Length - smoothingWindowSize; i++) {
                int windowSum = WindowSumAtIndex(depthArray, i, smoothingWindowSize);
                smoothedDepthList.Add(windowSum);
            }

            smoothedDepthArray = smoothedDepthList.ToArray<int>();

            return FindNumberOfDepthIncreases(smoothedDepthArray);
        }


        public int WindowSumAtIndex(int[] depthArray, int index, int windowSize) {
            int sum = 0;

            for(int i = index; i < index + windowSize; i++) {
                sum += depthArray[i];
            }

            return sum;
        }



        public int FindNumberOfDepthIncreases(string pathToReportFile) {
            int[] depthArray = ParseReportToIntArray(pathToReportFile);
            return FindNumberOfDepthIncreases(depthArray);
        }

        public int FindNumberOfDepthIncreases(int[] depthArray) {
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