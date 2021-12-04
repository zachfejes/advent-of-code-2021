using System;
using System.IO;
using AoC.Navigation;
using NUnit.Framework;

namespace AoC.Test.Unit {

    [TestFixture]
    public class NavigationAnalyzerUnitTests {

        [Test]
        public void NavigationAnalyzer_Constructor_Creates_Instance() {
            //ASSEMBLE

            //ACT
            NavigationAnalyzer possibleNavAnalyzer = new NavigationAnalyzer();

            //ASSERT
            Assert.IsInstanceOf<NavigationAnalyzer>(possibleNavAnalyzer);
        }


        [Test]
        public void ParseCommandsToStringArray_Takes_Valid_File_Reference_Outputs_Array() {
            //ASSEMBLE
            NavigationAnalyzer navAnalyzer = new NavigationAnalyzer();
            string validCourseCommandFile = Parameters.validCourseCommands;
            string[] expectedCommandArray = new string[] { "forward 5", "down 5", "forward 8", "up 3", "down 8", "forward 2" };

            //ACT
            string[] outputStringArray = navAnalyzer.ParseCommandsToStringArray(validCourseCommandFile);

            //ASSERT
            Assert.AreEqual(expectedCommandArray, outputStringArray);
        }

    }
}