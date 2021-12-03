using System;
using System.Threading.Tasks;
using AoC.Sonar;
using NUnit;
using NUnit.Framework;

namespace AoC.Test {

    [TestFixture]
    public class SonarAnalyzerUnitTests {

        [Test]
        public void Constructor_Creates_Instance(){
            //ASSEMMBLE
            //ACT
            SonarAnalyzer sonarAnalyzer = new SonarAnalyzer();

            //ASSERT
            Assert.IsInstanceOf<SonarAnalyzer>(sonarAnalyzer);
        }

        [Test]
        public async Task ParseReportToIntArray_Parses_File_From_Reference_To_Integer_Array() {
            //ASSEMBLE
            SonarAnalyzer analyzer = new SonarAnalyzer();
            string textFileReference = @"../../../UnitTests/TestReport.txt";
            int[] expectedOutputArray = {199, 200, 208, 210, 200, 207, 240, 269, 260, 263};

            //ACT
            var outputArray = analyzer.ParseReportToIntArray(textFileReference);

            //ASSERT
            Assert.AreEqual(expectedOutputArray, outputArray);
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