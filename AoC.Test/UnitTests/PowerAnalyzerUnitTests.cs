using System;
using AoC.Power;
using NUnit.Framework;

namespace AoC.Test.Unit {

    [TestFixture]
    public class PowerAnalyzerUnitTests {

        public static object[] validGammaEpsilonBinaryArrays = {
            new object[] { 
                new int[][]{ new int[] { 1, 0, 1 }, new int[] { 1, 1, 0 }, new int[] { 0, 0, 0 }}, 
                new int[]{ 1, 0, 0 }, 
                new int[] { 4, 3 } 
            },
            new object[] { 
                new int[][]{ new int[] { 1, 0 }, new int[] { 1, 1 }, new int[] { 0, 0 }, new int[] { 1, 1 }, new int[] {0, 1}}, 
                new int[] { 1, 1 }, 
                new int[] { 3, 0 } 
            },
            new object[] { 
                new int[][]{ new int[] { 0, 0 }, new int[] { 1, 0 }, new int[] { 0, 0 }}, 
                new int[] { 0, 0 }, 
                new int[] { 0, 3 }
            },
            new object[] { 
                new int[][]{ new int[] { 1, 1, 0, 1, 0, 1 }, new int[] { 1, 0, 0, 0, 0, 1 }, new int[] { 0, 0, 1, 1, 1 }}, 
                new int[] { 1, 0, 0, 1, 0, 1 },
                new int[] { 37, 26 }
            },
        };

        [Test]
        public void PowerAnalyzer_Constructor_Creates_Instance() {
            //ASSEMBLE
            //ACT
            PowerAnalyzer possiblePowerAnalyzer = new PowerAnalyzer();

            //ASSERT
            Assert.IsInstanceOf<PowerAnalyzer>(possiblePowerAnalyzer);
        }

        [Test]
        public void ParseReportToNestedIntArray_Parses_File_From_Reference_To_Nested_Integer_Array() {
            //ASSEMBLE
            PowerAnalyzer analyzer = new PowerAnalyzer();
            int[][] expectedParcedOutput = new int[][] {new int[]{ 1, 0, 1 }, new int[]{ 1, 1, 0 }, new int[]{ 0, 0, 0 }};
            string validFilePath = Parameters.validSimplePowerReport;

            //ACT
            int[][] parsedOutput = analyzer.ParseReportToNestedIntArray(validFilePath);

            //ASSERT
            Assert.AreEqual(expectedParcedOutput, parsedOutput);
        }


        [Test]
        public void ParseLine_Takes_String_And_Outputs_Int_Array() {
            //ASSEMBLE
            PowerAnalyzer analyzer = new PowerAnalyzer();
            string validBinaryString = "1010110";
            int[] expectedOutput = new int[] {1, 0, 1, 0, 1, 1, 0};

            //ACT
            int[] output = analyzer.ParseLine(validBinaryString);

            //ASSERT
            Assert.AreEqual(expectedOutput, output);
        }

        [TestCaseSource(nameof(validGammaEpsilonBinaryArrays))]
        public void CalculateGammaFromBinaryIntArray_Outputs_Correct_Gamma_Array(int[][] validBinaryIntArray, int[] expectedGammaArray, int[] expectedGammaAndEpsilon) {
            //ASSEMBLE
            PowerAnalyzer analyzer = new PowerAnalyzer();

            //ACT
            int[] outputGammaArray = analyzer.CalculateGammaFromBinaryIntArray(validBinaryIntArray);

            //ASSERT
            Assert.AreEqual(expectedGammaArray, outputGammaArray);
        }

        [TestCaseSource(nameof(validGammaEpsilonBinaryArrays))]
        public void CalculateGammaAndEpsilonRates_Takes_BinaryIntArray_And_Outputs_Correct_Gamma_and_Epsilon(int[][] validBinaryIntArray, int[] expectedGammaArray, int[] expectedGammaAndEpsilon ) {
            //ASSEMBLE
            PowerAnalyzer analyzer = new PowerAnalyzer();

            //ACT
            int[] outputGammaAndEpsilon = analyzer.CalculateGammaAndEpsilonRates(validBinaryIntArray);
            int[] badOutput = new int[]{ -1, -1 };

            //ASSERT
            Assert.AreEqual(expectedGammaAndEpsilon, outputGammaAndEpsilon);
        }

        [Test]
        public void CalculateReportPowerConsumption_Takes_Valid_Input_File_String_Outputs_Power_Consumption() {
            //ASSEMBLE
            PowerAnalyzer analyzer = new PowerAnalyzer();
            string validPowerReport = Parameters.validPowerReport;
            int expectedPowerConsumption = 198;

            //ACT
            int powerConsumption = analyzer.CalculateReportPowerConsumption(validPowerReport);

            //ASSERT
            Assert.AreEqual(expectedPowerConsumption, powerConsumption);
        }
    }
}