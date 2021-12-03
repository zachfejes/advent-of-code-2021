using System;
using System.IO;
using AoC.Sonar;
using NUnit.Framework;

namespace AoC.Test {

    [TestFixture]
    public class SonarAnalyzerUnitTests {

        public static object[] validReports = {
            new Object[] { Parameters.validTestReport, 7 },
            new Object[] { Parameters.singleLineTestReport, 0 },
            new Object[] { Parameters.constantValueTestReport, 0 },
            new Object[] { Parameters.decreaseOnlyTestReport, 0 },
            new Object[] { Parameters.increaseOnlyTestReport, 10 }
        };

        SonarAnalyzer analyzer;
        Exception thrownException;


        [SetUp]
        public void Setup() {
            analyzer = new SonarAnalyzer();
            thrownException = new Exception();
        }

        [Test]
        public void Constructor_Creates_Instance(){
            //ASSEMMBLE
            //ACT
            SonarAnalyzer potentialSonarAnalyzer = new SonarAnalyzer();

            //ASSERT
            Assert.IsInstanceOf<SonarAnalyzer>(potentialSonarAnalyzer);
        }

        [Test]
        public void ParseReportToIntArray_Parses_File_From_Reference_To_Integer_Array() {
            //ASSEMBLE
            string validFilePath = Parameters.validTestReport;
            int[] expectedOutputArray = {199, 200, 208, 210, 200, 207, 240, 269, 260, 263};

            //ACT
            var outputArray = analyzer.ParseReportToIntArray(validFilePath);

            //ASSERT
            Assert.AreEqual(expectedOutputArray, outputArray);
        }


        [Test]
        public void ParseReportToIntArray_Throws_IOException_If_Invalid_File_Reference() {
            //ASSEMBLE
            string nonexistantFilePath = Parameters.nonexistantTestReport;

            //ACT
            try {
                analyzer.ParseReportToIntArray(nonexistantFilePath);
            }
            catch (IOException e) {
                thrownException = e;
            }

            //ASSERT
            Assert.IsInstanceOf<IOException>(thrownException);
        }

        [Test]
        public void ParseReportToIntArray_Throws_FormatException_If_File_Contains_Unexpected_Format() {
            //ASSEMBLE
            string invalidFilePath = Parameters.invalidTestReport;

            //ACT
            try {
                analyzer.ParseReportToIntArray(invalidFilePath);
            }
            catch (FormatException e) {
                thrownException = e;
            }

            //ASSERT
            Assert.IsInstanceOf<FormatException>(thrownException);
        }

        [TestCaseSource(nameof(validReports))]
        public void FindNumberOfDepthIncreases_Valid_Report_Returns_Correct_Number_Of_Increases(string validFileReference, int expectedNumberOfDepthIncreases) {
            //ASSEMBLE
            //ACT
            int numberOfDepthIncreases = analyzer.FindNumberOfDepthIncreases(validFileReference);

            //ASSERT
            Assert.AreEqual(expectedNumberOfDepthIncreases, numberOfDepthIncreases);
        }


        [Test]
        public void WindowSumAtIndex_Given_Valid_Array_Index_And_Chosen_Length_Return_Sum_Of_Window_Values() {
            //ASSEMBLE
            int[] testArray = new int[] { 100, 200, 300, 250, 350, 425, 150, 500, 260, 600 };
            int windowSize = 3;
            int index = 5;
            int expectedWindowSum = 1075;
            
            //ACT
            int windowSum = analyzer.WindowSumAtIndex(testArray, index, windowSize);

            //ASSERT
            Assert.AreEqual(expectedWindowSum, windowSum);
        }

        [Test]
        public void FindNumberOfDepthIncreasesSmoothed_Valid_Report_Returns_Correct_Number_Of_Smoothed_Increases() {
            //ASSEMBLE
            int smoothingWindowSize = 3;
            int expectedDepthIncreasesSmoothed = 5;

            //ACT
            int numberOfSmoothedDepthIncreases = analyzer.FindNumberOfDepthIncreasesSmoothed(Parameters.validTestReport, smoothingWindowSize);

            //ASSERT
            Assert.AreEqual(expectedDepthIncreasesSmoothed, numberOfSmoothedDepthIncreases);
        }
    }
}