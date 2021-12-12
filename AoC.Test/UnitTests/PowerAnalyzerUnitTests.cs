using System;
using AoC.Diagnostic;
using NUnit.Framework;

namespace AoC.Test.Unit {

    [TestFixture]
    public class DiagnosticAnalyzerUnitTests {

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
        public void DiagnosticAnalyzer_Constructor_Creates_Instance() {
            //ASSEMBLE
            //ACT
            DiagnosticAnalyzer possibleDiagnosticAnalyzer = new DiagnosticAnalyzer();

            //ASSERT
            Assert.IsInstanceOf<DiagnosticAnalyzer>(possibleDiagnosticAnalyzer);
        }

        [Test]
        public void ParseReportToNestedIntArray_Parses_File_From_Reference_To_Nested_Integer_Array() {
            //ASSEMBLE
            DiagnosticAnalyzer analyzer = new DiagnosticAnalyzer();
            int[][] expectedParcedOutput = new int[][] {new int[]{ 1, 0, 1 }, new int[]{ 1, 1, 0 }, new int[]{ 0, 0, 0 }};
            string validFilePath = Parameters.validSimpleDiagnosticReport;

            //ACT
            int[][] parsedOutput = analyzer.ParseReportToNestedIntArray(validFilePath);

            //ASSERT
            Assert.AreEqual(expectedParcedOutput, parsedOutput);
        }


        [Test]
        public void ParseLine_Takes_String_And_Outputs_Int_Array() {
            //ASSEMBLE
            DiagnosticAnalyzer analyzer = new DiagnosticAnalyzer();
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
            DiagnosticAnalyzer analyzer = new DiagnosticAnalyzer();

            //ACT
            int[] outputGammaArray = analyzer.CalculateGammaFromBinaryIntArray(validBinaryIntArray);

            //ASSERT
            Assert.AreEqual(expectedGammaArray, outputGammaArray);
        }

        [TestCaseSource(nameof(validGammaEpsilonBinaryArrays))]
        public void CalculateGammaAndEpsilonRates_Takes_BinaryIntArray_And_Outputs_Correct_Gamma_and_Epsilon(int[][] validBinaryIntArray, int[] expectedGammaArray, int[] expectedGammaAndEpsilon ) {
            //ASSEMBLE
            DiagnosticAnalyzer analyzer = new DiagnosticAnalyzer();

            //ACT
            int[] outputGammaAndEpsilon = analyzer.CalculateGammaAndEpsilonRates(validBinaryIntArray);
            int[] badOutput = new int[]{ -1, -1 };

            //ASSERT
            Assert.AreEqual(expectedGammaAndEpsilon, outputGammaAndEpsilon);
        }

        [Test]
        public void CalculateReportPowerConsumption_Takes_Valid_Input_File_String_Outputs_Power_Consumption() {
            //ASSEMBLE
            DiagnosticAnalyzer analyzer = new DiagnosticAnalyzer();
            string validDiagnosticReport = Parameters.validDiagnosticReport;
            int expectedPowerConsumption = 198;

            //ACT
            int powerConsumption = analyzer.CalculateReportPowerConsumption(validDiagnosticReport);

            //ASSERT
            Assert.AreEqual(expectedPowerConsumption, powerConsumption);
        }
    }
}