namespace SimcorpMobilePhone.Model {
    public abstract class Microphone {
        public int Sensitivity { get; set; }
        public string MicrophoneModel { get; set; }

        public abstract void Record();
    }
}
