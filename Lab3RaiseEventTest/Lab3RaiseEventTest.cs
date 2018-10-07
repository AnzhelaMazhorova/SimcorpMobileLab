using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimcorpMobile.Model;
using SimcorpMobilePhone.Model;

namespace Lab3RaiseEventTest {
    [TestClass]
    public class Lab3RaiseEventTest {
        [TestMethod]
        public void RaiseEventTest() {
            //--Arrange
            MobileSimcorp Samsung = new MobileSimcorp();
            Message message = new Message("User 1", "message #1 received", DateTime.Now);
            bool raisedEvent = false;

            //--Act
            Samsung.SMSProvider.SMSReceived += (msg) => { raisedEvent = true; };
            Samsung.SMSProvider.GetSms(message.Text);

            //--Assert
            Assert.IsTrue(raisedEvent);
        }
    }
}
