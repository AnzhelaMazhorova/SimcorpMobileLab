using System;

namespace SimcorpMobile.Model {
    public class MessageFormatting {

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
