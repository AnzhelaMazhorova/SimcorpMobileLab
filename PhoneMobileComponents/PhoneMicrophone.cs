namespace SimcorpMobilePhone.Model {
    public class PhoneMicrophone : Microphone {

        public PhoneMicrophone(int sensitivity, string microphoneModel) {
            this.Sensitivity = sensitivity;
            this.MicrophoneModel = microphoneModel;
        }

        public override void Record() { }
        public override string ToString() {
            return "Sensitivity = " + Sensitivity + "; Microphone Model = " + MicrophoneModel;
        }
    }
}
