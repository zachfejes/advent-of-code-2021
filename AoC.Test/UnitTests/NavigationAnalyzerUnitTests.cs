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



    }
}