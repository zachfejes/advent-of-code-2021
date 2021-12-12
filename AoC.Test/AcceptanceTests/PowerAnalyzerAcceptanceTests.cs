using NUnit.Framework;
using AoC.Diagnostic;

namespace AoC.Test.Acceptance {
    /* Acceptance Criteria:
        GIVEN the power report has been generated nominally and is valid
        WHEN the power analyzer system receives a power report
        THEN the the power analyzer system shall output the power consumption in decimal
    */

    [TestFixture]
    public class DiagnosticAnalyzerAcceptanceTests {

        [Test]
        public void Diagnostic_Analyzer_Parses_Valid_Power_Report_And_Outputs_Decimal_Power_Consumption() {
            //ASSEMBLE
            DiagnosticAnalyzer diagnosticAnalyzer = new DiagnosticAnalyzer();
            string navigationPlanFile = Parameters.day3AInputs;
            int expectedPowerConsumption = 2954600;

            //ACT
            int powerConsumption = diagnosticAnalyzer.CalculateReportPowerConsumption(navigationPlanFile);

            //ASSERT
            Assert.AreEqual(expectedPowerConsumption, powerConsumption);
        }
    }
}