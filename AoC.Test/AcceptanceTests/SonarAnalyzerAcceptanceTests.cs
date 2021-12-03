using NUnit.Framework;
using AoC.Sonar;

namespace AoC.Test {
    /* Acceptance Criteria:
        GIVEN that the sonar has been triggered nominally
        WHEN the sonar analyzer receive a sweep report of numeric values as a text file
        THEN the sonar analyzer shall output the number of values that indicate an increased depth
    */

    [TestFixture]
    public class SonarAnalyzerAccetanceTests {

        public static object[] validReports = {
            new object[] { Parameters.day1AInputs , 1342 }
        };

        [TestCaseSource(nameof(validReports))]
        public void Sonar_Analyzer_Outputs_Number_Of_Depth_Increases_In_Report(string validDepthReport, int expectedDepthIncreases) {
            //ASSEMBLE
            SonarAnalyzer sonarAnalyzer = new SonarAnalyzer();

            //ACT
            int possibleIncreases = sonarAnalyzer.FindNumberOfDepthIncreases(validDepthReport);

            //ASSERT
            Assert.AreEqual(expectedDepthIncreases, possibleIncreases);
        }

    }

}