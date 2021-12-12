namespace AoC.Test {

    public static class Parameters {

        //Unit Test Input Files

        public static string unitTestInputDirectoryPath = @"../../../UnitTests/TestInputFiles/";

        //Power Report Test Files

        public static string powerReportDirectoryPath = unitTestInputDirectoryPath + @"PowerReports/";

        public static string validPowerReport = powerReportDirectoryPath + @"ValidPowerReport.txt";
        public static string validSimplePowerReport = powerReportDirectoryPath + @"ValidSimplePowerReport.txt";
        public static string singleLinePowerReport = powerReportDirectoryPath + @"SingleLinePowerReport.txt";
        public static string emptyPowerReport = powerReportDirectoryPath + @"EmptyPowerReport.txt";
        public static string invalidPowerReport = powerReportDirectoryPath + @"InvalidPowerReport.txt";

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