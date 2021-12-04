using System;
using System.IO;
using AoC.Navigation;
using NUnit.Framework;

namespace AoC.Test.Unit {

    [TestFixture]
    public class NavigationAnalyzerUnitTests {
        [Test]
        public void NavCommand_Constructor_Assigns_Attributes_From_Parameters() {
            //ASSEMBLE
            string expectedDirection = "forward";
            int expectedMagnitude = 5;

            //ACT
            NavCommand navCommand = new NavCommand(expectedDirection, expectedMagnitude);

            //ASSERT
            Assert.Multiple(() => {
                Assert.AreEqual(expectedDirection, navCommand.direction);
                Assert.AreEqual(expectedMagnitude, navCommand.magnitude);
            });
        }


        [Test]
        public void NavigationAnalyzer_Constructor_Creates_Instance() {
            //ASSEMBLE
            //ACT
            NavigationAnalyzer possibleNavAnalyzer = new NavigationAnalyzer();

            //ASSERT
            Assert.IsInstanceOf<NavigationAnalyzer>(possibleNavAnalyzer);
        }


        [Test]
        public void ParseFileToNavCommandArray_Takes_Valid_File_Reference_Outputs_Array() {
            //ASSEMBLE
            NavigationAnalyzer navAnalyzer = new NavigationAnalyzer();
            string validCourseCommandFile = Parameters.validCourseCommands;
            NavCommand[] expectedNavCommandArray = new NavCommand[] { 
                new NavCommand("forward", 5),
                new NavCommand("down", 5),
                new NavCommand("forward", 8),
                new NavCommand("up", 3),
                new NavCommand("down", 8),
                new NavCommand("forward", 2)
            };

            //ACT
            NavCommand[] outputNavCommandArray = navAnalyzer.ParseFileToNavCommandArray(validCourseCommandFile);

            //ASSERT
            Assert.Multiple(() => {
                for(int i = 0; i < expectedNavCommandArray.Length; i++) {
                    Assert.AreEqual(expectedNavCommandArray[i].direction, outputNavCommandArray[i].direction);
                    Assert.AreEqual(expectedNavCommandArray[i].magnitude, outputNavCommandArray[i].magnitude);
                }
            });
        }


        [Test]
        public void ParseNavCommandString_Reads_Valid_String_And_Creates_NavCommand_With_Values() {
            //ASSEMBLE
            NavigationAnalyzer navAnalyzer = new NavigationAnalyzer();
            string validCommandString = "forward 5";
            string expectedDirection = "forward";
            int expectedMagnitude = 5;

            //ACT
            NavCommand possibleNavCommand = navAnalyzer.ParseNavCommandString(validCommandString);

            //ASSERT
            Assert.Multiple(() => {
                Assert.AreEqual(expectedDirection, possibleNavCommand.direction);
                Assert.AreEqual(expectedMagnitude, possibleNavCommand.magnitude);
            });
        }


        [Test]
        public void CalculateNavPlanTotalVectorProduct_Takes_Valid_Command_File_Outputs_Total_Vector_Product() {
            //ASSEMBLE
            NavigationAnalyzer navAnalyzer = new NavigationAnalyzer();
            string validCourseCommandFile = Parameters.validCourseCommands;
            int expectedProduct = 150; 

            //ACT
            int calculatedProduct = navAnalyzer.CalculateNavPlanTotalVectorProduct(validCourseCommandFile);

            //ASSERT
            Assert.AreEqual(expectedProduct, calculatedProduct);
        } 


        [Test]
        public void CalculateNavPlanFinalPosition_Takes_Valid_Command_File_Outputs_Final_Position() {
            //ASSEMBLE
            NavigationAnalyzer navAnalyzer = new NavigationAnalyzer();
            string validCourseCommandFile = Parameters.validCourseCommands;
            int[] expectedPosition = new int[]{ 15, 60 };

            //ACT
            int[] calculatedFinalPosition = navAnalyzer.CalculateNavPlanFinalPosition(validCourseCommandFile);

            //ASSERT
            Assert.AreEqual(expectedPosition, calculatedFinalPosition);
        }

    }
}