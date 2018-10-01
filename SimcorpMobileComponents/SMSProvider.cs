using System;

namespace SimcorpMobileComponents {
    public class SMSProvider {
        public delegate void SMSReceivedDelegate(string message);
        public event SMSReceivedDelegate SMSReceived;

        public void RaiseSMSReceivedEvent(string message) {
            var handler = SMSReceived;
            if (handler != null) {
                handler(message);
            }
        }

        public static string FormatWithTime(string message) {
            return $"[{DateTime.Now}]{message}";
        }

        public static string FormatWithUpperCase(string message) {
            return message.ToUpper();
        }

        public static string FormatWithLowerCase(string message) {
            return message.ToLower();
        }

        
    }
}
