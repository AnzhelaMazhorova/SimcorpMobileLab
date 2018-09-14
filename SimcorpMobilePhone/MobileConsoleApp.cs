using System;
using SimcorpMobilePhone.Model;
using SimcorpMobilePhone.View;
using System.Collections.Generic;

namespace SimcorpMobilePhone {
    class MobileConsoleApp {

        public static void Main(string[] args) {

            //Select Speaker type:
            VoiceOutput VoiceOutput = new VoiceOutput();
            Dictionary<int, ISpeaker> availableSpeakers = new Dictionary<int, ISpeaker>();
            availableSpeakers.Add(1, new IphoneHeadset(VoiceOutput, "IphoneX", true));
            availableSpeakers.Add(2, new SamsungHeadset(VoiceOutput, "SamsungA", true));
            availableSpeakers.Add(3, new PhoneSpeaker(VoiceOutput, "model-ABC"));

            ISpeaker Speaker = null;

            while (Speaker == null) {
                Menu.ShowHeadsetMenu();

                string speakerSelected = Console.ReadLine();

                foreach (var item in availableSpeakers) {
                    if (speakerSelected.Equals(item.Key.ToString())) {
                        Speaker = availableSpeakers[item.Key];
                        VoiceOutput.DataOutput("Speaker selected");
                        Speaker.Play(null);
                    };
                }
                if (Speaker == null) {
                    VoiceOutput.DataOutput("There is no such option. Please try again");
                }
            }

            //Select the Screen type:
            TextOutput TextOutput = new TextOutput();
            Dictionary<int, ScreenBase> availableScreens = new Dictionary<int, ScreenBase>();
            availableScreens.Add(1, new MonochromeScreen(TextOutput, 300,5));
            availableScreens.Add(2, new ColorfulScreen(TextOutput, 300, 5, false));

            ScreenBase Screen = null;

            while (Screen == null) {
                Menu.ShowScreenMenu();

                string screenSelected = Console.ReadLine();

                foreach (var item in availableScreens) {
                    if (screenSelected.Equals(item.Key.ToString())) {
                        Screen = availableScreens[item.Key];
                        TextOutput.DataOutput("Set screen to Mobile... Selected screen is ");
                        Screen.DisplayInfo();            
                    }
                }
                if (Screen == null) {
                    TextOutput.DataOutput("There is no such option. Please try again");
                }
            }

            Console.ReadLine();

            //From Lab#1:
            //ScreenBase Screen = new ColorfulScreen(7.0, 500, true);
            //IBattery Battery = new Battery(2000, "Li-ion");
            //Keyboard Keyboard = new SensorKeyboard("Russian", "Samsung");
            //Microphone Microphone = new PhoneMicrophone(94, "model-xxx0155");
            //ISpeaker Speaker = new SamsungHeadset("model-XXX", false);
            //SimCard SimCard = new MTSSimCard(SimCardType.NanoSim, 1111);
            //Mobile Samsung = new MobileSimcorp(Screen, Battery, Keyboard, Microphone, Speaker, SimCard);
            //Console.WriteLine(Samsung.GetDescription());

        }
    }
}
