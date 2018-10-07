using System;
using SimcorpMobilePhone.Model;
using SimcorpMobilePhone.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab2MobilePhoneTest {
    [TestClass]
    public class Lab2DataOutputTest {
        [TestMethod]
        public void DataOutputEmptyData() {

            //--Arrange
            TestOutput TestOutput = new TestOutput();
            string expectedOutput = null;
            
            //--Act
            TestOutput.DataOutput(expectedOutput);
            
            //--Assert
            Assert.AreEqual(expectedOutput, TestOutput.DataOutputTest );
        }

        [TestMethod]
        public void DataOutputSomeData() {

            //--Arrange
            TestOutput TestOutput2 = new TestOutput();
            string expectedOutput2 = "IPhoneHeadset sound";
            
            //--Act
            TestOutput2.DataOutput(expectedOutput2);

            //--Assert
            Assert.AreEqual(expectedOutput2, TestOutput2.DataOutputTest);
        }

    }
}
