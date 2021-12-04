using NUnit.Framework;
using AoC.Sonar;

namespace AoC.Test.Acceptance {
    /* Acceptance Criteria:
        GIVEN that the sonar has been triggered nominally
        WHEN the sonar analyzer receive a sweep report of numeric values as a text file
        THEN the sonar analyzer shall output the number of values that indicate an increased depth
    */

    [TestFixture]
    public class SonarAnalyzerAccetanceTests {

        public static object[] validReports = {
            new object[] { Parameters.day1AInputs , 1342, 1378 }
        };

        SonarAnalyzer sonarAnalyzer;

        [SetUp]
        public void Setup() {
            sonarAnalyzer = new SonarAnalyzer();
        }


        [TestCaseSource(nameof(validReports))]
        public void Sonar_Analyzer_Outputs_Number_Of_Depth_Increases_In_Report(string validDepthReport, int expectedDepthIncreases, int expectedDepthIncreasesSmoothed) {
            //ASSEMBLE
            //ACT
            int depthIncreases = sonarAnalyzer.FindNumberOfDepthIncreases(validDepthReport);

            //ASSERT
            Assert.AreEqual(expectedDepthIncreases, depthIncreases);
        }



        [TestCaseSource(nameof(validReports))]
        public void Sonar_Analyzer_Outputs_Number_Of_Depth_Increases_From_Report_Window_Smoothing(string validDepthReport, int expectedDepthIncreases, int expectedDepthIncreasesSmoothed) {
            //ASSEMBLE
            int windowSize = 3;

            //ACT
            int depthIncreasesSmoothed = sonarAnalyzer.FindNumberOfDepthIncreasesSmoothed(validDepthReport, windowSize);

            //ASSERT
            Assert.AreEqual(expectedDepthIncreasesSmoothed, depthIncreasesSmoothed);
        }

    }

}