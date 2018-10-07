using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimcorpMobile.Model;

namespace Lab3MessageFormattingTest {
    [TestClass]
    public class Lab3MessageFormattingTest {
        [TestMethod]
        public void FormatWithTime() {
            //--Arrange
            MessageFormatting format = new MessageFormatting();
            // Act
            string expectedString = $"[{DateTime.Now}]message #1 received";

            //Assert;
            Assert.AreEqual(expectedString, MessageFormatting.FormatWithTime("message #1 received"));
        }

        [TestMethod]
        public void FormatWithUpperCase() {
            //--Arrange
            MessageFormatting format = new MessageFormatting();
            // Act
            string expectedString = $"MESSAGE #1 RECEIVED";

            //Assert;
            Assert.AreEqual(expectedString, MessageFormatting.FormatWithUpperCase("Message #1 received"));
        }

        [TestMethod]
        public void FormatWithLowerCase() {
            //--Arrange
            MessageFormatting format = new MessageFormatting();
            // Act
            string expectedString = $"message #1 received";

            //Assert;
            Assert.AreEqual(expectedString, MessageFormatting.FormatWithLowerCase("Message #1 received"));
        }
    }
}
