namespace AoC.Sonar {

    public class SonarAnalyzer {

        public int FindNumberOfDepthIncreases(string pathToReportFile) {
            int[] depthArray = ParseReportToIntArray(pathToReportFile);
            return FindNumberOfDepthIncreasesSmoothed(depthArray, 1);
        }

        public int FindNumberOfDepthIncreases(int[] depthArray) {
            return FindNumberOfDepthIncreasesSmoothed(depthArray, 1);
        }

        public int FindNumberOfDepthIncreasesSmoothed(string pathToReportFile, int smoothingWindowSize) {
            int[] depthArray = ParseReportToIntArray(pathToReportFile);
            return FindNumberOfDepthIncreasesSmoothed(depthArray, smoothingWindowSize);
        }

        public int FindNumberOfDepthIncreasesSmoothed(int[] depthArray, int smoothingWindowSize) {
            int numberOfDepthIncreases = 0;

            for(int i = 1; i <= depthArray.Length - smoothingWindowSize; i++) {
                int windowSum = WindowSumAtIndex(depthArray, i, smoothingWindowSize);
                int previousWindowSum = WindowSumAtIndex(depthArray, i - 1, smoothingWindowSize);

                if(windowSum > previousWindowSum) {
                    numberOfDepthIncreases++;
                }
            }

            return numberOfDepthIncreases;
        }

        public int WindowSumAtIndex(int[] depthArray, int index, int windowSize) {
            int sum = 0;

            for(int i = index; i < index + windowSize; i++) {
                sum += depthArray[i];
            }

            return sum;
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