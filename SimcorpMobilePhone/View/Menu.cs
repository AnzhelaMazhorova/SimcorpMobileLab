using System;

namespace SimcorpMobilePhone.View {
    public class Menu {

        public static void ShowHeadsetMenu() {
            Console.WriteLine("Select playback component (specify index): \n 1 - " +
                "IphoneHeadset \n 2 - SamsungHeadset \n 3 - PhoneSpeaker");
        }

        public static void ShowScreenMenu() {
            Console.WriteLine("\nSelect Screen type (specify index): \n 1 - Monochrome screen" +
                "\n 2 - Colorful screen");
        } 
    }
}
