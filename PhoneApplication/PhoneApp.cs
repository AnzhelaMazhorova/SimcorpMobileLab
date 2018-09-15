using System;
using System.Windows.Forms;
using SimcorpMobilePhone.Model;

namespace PhoneApplication {
    public partial class PhoneApp : Form {
        public PhoneApp() {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            //1st group of radio-buttons (Speaker settings):
            VoiceOutput VoiceOutput = new VoiceOutput();
            ISpeaker Speaker = null;

            if (IPhoneHeadset.Checked) {
                Speaker = new IphoneHeadset(VoiceOutput, "IphoneX", true);
            } else if (SamsungHeadset.Checked) {
                Speaker = new SamsungHeadset(VoiceOutput, "SamsungA", true);
            } else if (PhoneSpeaker.Checked) {
                Speaker = new PhoneSpeaker(VoiceOutput, "model-ABC");
            } else { };

            //there is an option not to select radio button without assertion error 
            if (Speaker != null) {
                VoiceOutput.DataOutput("Speaker selected");
                Speaker.Play(null);
            } else {
                VoiceOutput.DataOutput("Speaker is not selected");
            }

            //2nd group of radio-buttons (Screen settings)
            TextOutput TextOutput = new TextOutput();
            ScreenBase Screen = null;    
            string screenType = null;

            if (MonochromeScreen.Checked) {
                Screen = new MonochromeScreen(TextOutput, 2.0, 200);
                screenType = nameof(MonochromeScreen);
            } else if (ColorfulScreen.Checked) {
                Screen = new ColorfulScreen(TextOutput, 7.0, 500, true);
                screenType = nameof(ColorfulScreen);
            }

            //there is an option not to select radio button without assertion error
            if (Screen != null) {
                textBox1.Text = "Set screen to Mobile... \n Selected screen is " + screenType;
            } else {
                textBox1.Text = "Screen is not selected";
            }

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e) {

        }

        private void PhoneApp_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }
    }
}
