using AoC.Sonar;
using NUnit.Framework;

namespace AoC.Test {

    [TestFixture]
    public class SonarAnalyzerUnitTests {


        //Test that we can create a SonarAnalyzer object (constructor)
        [Test]
        public void SonarAnalyzer_Constructor_Creates_Object()
        {
            //ASSEMMBLE

            //ACT
            SonarAnalyzer sonarAnalyzer = new SonarAnalyzer();

            //ASSERT
            Assert.NotNull(sonarAnalyzer);
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