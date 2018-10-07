using System;

namespace SimcorpMobile.Model {
    public class SMSProvider {

        public SMSProvider() { }

        //SMS Receieved in simple string format:
        public delegate void SMSReceivedDelegate(string message);
        public event SMSReceivedDelegate SMSReceived;

        private void RaiseSMSReceivedEvent(string message) {
            SMSReceived?.Invoke(message);
        }

        public void GetSms(string message) {
            RaiseSMSReceivedEvent(message);
        }

        //SMS Received in Message list format (User, Text, Date):
        public delegate void SMSMessageReceivedDelegate(Message message);
        public event SMSMessageReceivedDelegate SMSMessageReceived;

        private void RaiseSMSReceivedEvent(Message message) {
            SMSMessageReceived?.Invoke(message);
        }

        public void GetSms(Message message) {
            RaiseSMSReceivedEvent(message);
        }
    }
}
