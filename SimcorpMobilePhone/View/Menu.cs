using SimcorpMobilePhone.Model;
using System;

namespace SimcorpMobilePhone.View {
    public class Menu {

        public static void ShowHeadsetMenu() {

            TextOutput textOutput = new TextOutput();

            textOutput.DataOutput("Select speaker component (specify index): \n 1 - " +
                "IphoneHeadset \n 2 - SamsungHeadset \n 3 - PhoneSpeaker");

        }

        public static void ShowScreenMenu() {
            TextOutput textOutput = new TextOutput();

            textOutput.DataOutput("\nSelect Screen type (specify index): \n 1 - Monochrome screen" +
                "\n 2 - Colorful screen");
        } 
    }
}
