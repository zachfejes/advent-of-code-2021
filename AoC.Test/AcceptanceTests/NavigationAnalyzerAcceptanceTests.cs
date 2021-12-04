using NUnit.Framework;
using AoC.Navigation;

namespace AoC.Test.Acceptance {
    /* Acceptance Criteria:
        GIVEN that the course plan has been generated nominally and is valid
        WHEN the the navigation system receives a course plan
        THEN the the navigation system shall output the total magnitude of the vector traversed in the course plan
    */

    [TestFixture]
    public class NavigationAnalyzerAcceptanceTests {

        [Test]
        public void Navigation_Analyzer_Parses_Valid_Commands_File_And_Outputs_Total_Vector_Product() {
            //ASSEMBLE
            NavigationAnalyzer navAnalyzer = new NavigationAnalyzer();
            string navigationPlanFile = Parameters.day2AInupts;
            int expectedPlanDistance = 1692075;

            //ACT
            int navigationPlanDistance = navAnalyzer.CalculateNavPlanTotalVectorProduct(navigationPlanFile);

            //ASSERT
            Assert.AreEqual(expectedPlanDistance, navigationPlanDistance);
        }



        [Test]
        public void Navigation_Analyzer_Parses_Valid_Commands_File_And_Outputs_Final_Position_Vector() {
            //ASSEMBLE
            NavigationAnalyzer navAnalyzer = new NavigationAnalyzer();
            string navigationPlanFile = Parameters.day2AInupts;
            int[] expectedPosition = new int[]{ 1925, 908844 };

            //ACT
            int[] calculatedFinalPosition = navAnalyzer.CalculateNavPlanFinalPosition(navigationPlanFile);

            //ASSERT
            Assert.AreEqual(expectedPosition, calculatedFinalPosition);
        }
    }
}
