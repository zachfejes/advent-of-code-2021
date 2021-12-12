namespace AoC.Diagnostic {

    public class DiagnosticAnalyzer {

        public int[][] ParseReportToNestedIntArray(string pathToReportFile) {
            List<int[]> diagnosticDataArray = new List<int[]>();

            foreach(string line in File.ReadLines(pathToReportFile)) {
                List<int> binaryLine = new List<int>(ParseLine(line));
                diagnosticDataArray.Add(binaryLine.ToArray<int>());
            }

            return diagnosticDataArray.ToArray<int[]>();
        }

        public int[] ParseLine(string line) {
            int [] binaryIntArray = new int[line.Length];

            try {
                for(int i = 0; i < binaryIntArray.Length; i++) {
                    binaryIntArray[i] = int.Parse(line[i].ToString());
                }
            }
            catch {
                throw new FormatException("Diagnostic Report does not conform to expected format.");
            }

            return binaryIntArray;
        }

        public int[] CalculateGammaFromBinaryIntArray(int[][] binaryIntArray) {
            int[] sumTracker = new int[binaryIntArray[0].Length];
            Array.Fill<int>(sumTracker, 0);
            float comparisonPoint = (float)binaryIntArray.Length / 2.0f;

            for(int i = 0; i < binaryIntArray.Length; i++) {
                for(int j = 0; j < binaryIntArray[i].Length; j++) {
                    if(binaryIntArray[i][j] == 1) {
                        sumTracker[j] += 1;
                    }
                }
            }

            for(int i = 0; i < sumTracker.Length; i++) {
                if(sumTracker[i] >= comparisonPoint) {
                    sumTracker[i] = 1;
                }
                else {
                    sumTracker[i] = 0;
                }
            }

            return sumTracker;
        }

        public int[] CalculateGammaAndEpsilonRates(int[][] binaryIntArray) {
            int[] gammaIntArray = CalculateGammaFromBinaryIntArray(binaryIntArray);
            Console.WriteLine("Gamma Array: " + String.Join("", gammaIntArray));

            string gammaString = String.Join("", gammaIntArray);
            int gamma = Convert.ToInt32(gammaString, 2);
            int epsilon = (int)Math.Pow(2, gammaIntArray.Length) - 1 - gamma;

            return new int[]{ gamma, epsilon };
        }

        public int CalculateReportPowerConsumption(string pathToReportFile) {
            int[][] reportPowerData = ParseReportToNestedIntArray(pathToReportFile);
            int[] gammaAndEpsilon = CalculateGammaAndEpsilonRates(reportPowerData);

            Console.WriteLine("Gamma And Epsilon:");
            Console.WriteLine(gammaAndEpsilon[0]);
            Console.WriteLine(gammaAndEpsilon[1]);

            return gammaAndEpsilon[0] * gammaAndEpsilon[1];
        }

    }

}