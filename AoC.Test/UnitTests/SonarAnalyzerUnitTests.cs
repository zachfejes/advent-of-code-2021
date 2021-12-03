using System;
using System.IO;
using System.Threading.Tasks;
using AoC.Sonar;
using NUnit;
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


        [Test]
        public void Constructor_Creates_Instance(){
            //ASSEMMBLE
            //ACT
            SonarAnalyzer sonarAnalyzer = new SonarAnalyzer();

            //ASSERT
            Assert.IsInstanceOf<SonarAnalyzer>(sonarAnalyzer);
        }

        [Test]
        public void ParseReportToIntArray_Parses_File_From_Reference_To_Integer_Array() {
            //ASSEMBLE
            SonarAnalyzer analyzer = new SonarAnalyzer();
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
            SonarAnalyzer analyzer = new SonarAnalyzer();
            string nonexistantFilePath = Parameters.nonexistantTestReport;
            Exception thrownException = new Exception();

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
            SonarAnalyzer analyzer = new SonarAnalyzer();
            string invalidFilePath = Parameters.invalidTestReport;
            Exception thrownException = new Exception();

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
            SonarAnalyzer analyzer = new SonarAnalyzer();

            //ACT
            int numberOfDepthIncreases = analyzer.FindNumberOfDepthIncreases(validFileReference);

            //ASSERT
            Assert.AreEqual(expectedNumberOfDepthIncreases, numberOfDepthIncreases);
        }


        // Calling the FindNumberOfDepthIncreases method with an array of integers will provide the correct number of depth increases in that array

        // Calling the FindNumberOfDepthIncreases with the following parameterizations will return 0:
        // { }
        // { 100 }
        // { 0 }
        // { -100 }

        // Calling the FindNumberOfDepthIncreases method with any invalid parameter will return -1
        // null
        // undefined
        // int[][] { { 100, 200 }, { 300, 400 } }
        // char[] {"100", "200"}
        // int 100;
        // float[] { 100.0f, 200.0f }


        // Calling the ParseReportTextToArray method with a text file reference will parse each line of that file into an element in an integer array
    }
}