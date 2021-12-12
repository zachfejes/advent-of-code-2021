namespace AoC.Test {

    public static class Parameters {

        //Unit Test Input Files

        public static string unitTestInputDirectoryPath = @"../../../UnitTests/TestInputFiles/";

        //Diagnostic Report Test Files

        public static string DiagnosticReportDirectoryPath = unitTestInputDirectoryPath + @"DiagnosticReports/";

        public static string validDiagnosticReport = DiagnosticReportDirectoryPath + @"ValidReport.txt";
        public static string validSimpleDiagnosticReport = DiagnosticReportDirectoryPath + @"ValidSimpleReport.txt";
        public static string singleLineDiagnosticReport = DiagnosticReportDirectoryPath + @"SingleLineReport.txt";
        public static string emptyDiagnosticReport = DiagnosticReportDirectoryPath + @"EmptyReport.txt";
        public static string invalidDiagnosticReport = DiagnosticReportDirectoryPath + @"InvalidReport.txt";

        //Sonar Report Test Files
        public static string validTestReport = unitTestInputDirectoryPath + @"ValidTestReport.txt";
        public static string singleLineTestReport = unitTestInputDirectoryPath + @"SingleLineTestReport.txt";
        public static string constantValueTestReport = unitTestInputDirectoryPath + @"ConstantValueTestReport.txt";
        public static string decreaseOnlyTestReport = unitTestInputDirectoryPath + @"DecreaseOnlyTestReport.txt";
        public static string increaseOnlyTestReport = unitTestInputDirectoryPath + @"IncreaseOnlyTestReport.txt";
        public static string nonexistantTestReport = unitTestInputDirectoryPath + @"NonexistantTestReport.txt";
        public static string invalidTestReport = unitTestInputDirectoryPath + @"InvalidTestReport.txt";


        //Navigation Report Test Files
        public static string validCourseCommands = unitTestInputDirectoryPath + @"ValidCourseCommands.txt";

        

        //Acceptance Test Input Files

        public static string acceptanceTestInputDirectoryPath = @"../../../AcceptanceTests/TestInputFiles/";

        public static string day1AInputs = acceptanceTestInputDirectoryPath + @"Day1AInputs.txt";
        public static string day2AInupts = acceptanceTestInputDirectoryPath + @"Day2AInputs.txt";        
        public static string day3AInputs = acceptanceTestInputDirectoryPath + @"Day3AInputs.txt";

    }
}