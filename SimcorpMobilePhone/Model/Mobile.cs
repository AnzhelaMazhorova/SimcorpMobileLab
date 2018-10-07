using SimcorpMobile.Model;

namespace SimcorpMobilePhone.Model {
    public abstract class Mobile {
        public ScreenBase Screen { get; set; }
        public IBattery Battery { get; set; }
        public Keyboard Keyboard { get; set; }
        public Microphone Microphone { get; set; }
        public ISpeaker Speaker { get; set; }
        public SimCard SimCard { get; set; }
        public SMSProvider SMSProvider { get; set; }
        public SMSStorage SMSStorage { get; set; }

        public abstract string GetDescription();
        public abstract void AddContact();
        public abstract void SetRington();
        public abstract void MakeCall();
        public abstract void SendSMS();
    }
}
