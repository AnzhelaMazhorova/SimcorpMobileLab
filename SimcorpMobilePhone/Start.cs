using System;
using SimcorpMobilePhone.Model;
using SimcorpMobilePhone.View;
using System.Collections.Generic;

namespace SimcorpMobilePhone {
    class Start {

        //private static Dictionary<int, ISpeaker> availableSpeakers = new Dictionary<int, ISpeaker>();
        //available(new SamsungHeadset(Output, "SamsungA", true));

        static void Main(string[] args) {

            Menu.ShowHeadsetMenu();
            string speaker = Console.ReadLine();
            ISpeaker Speaker = null;
            VoiceOutput VoiceOutput = new VoiceOutput();

            

            if (speaker == "1") {
                Speaker = new IphoneHeadset (VoiceOutput, "IphoneX", true);
            } else if (speaker == "2") {
                Speaker = new SamsungHeadset(VoiceOutput, "SamsungA", true);
            } else if (speaker == "3") {
                Speaker = new PhoneSpeaker(VoiceOutput, "model-ABC");
            } else { VoiceOutput.DataOutput("There is no such option"); Console.ReadLine(); }

            VoiceOutput.DataOutput("Speaker selected");
            Speaker.Play(null);

            Menu.ShowScreenMenu();
            string menu = Console.ReadLine();
            ScreenBase Screen = null;
            TextOutput TextOutput = new TextOutput();

            if (menu == "1") {
                Screen = new MonochromeScreen(TextOutput, 2.0, 200);
            } else if (menu == "2") {
                Screen = new ColorfulScreen(TextOutput,7.0, 500, true);
            } else { TextOutput.DataOutput("There is no such option"); Console.ReadLine(); }

            TextOutput.DataOutput("Set screen to Mobile... Selected screen is ");
            Screen.DisplayInfo();
            Console.ReadLine();            

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
