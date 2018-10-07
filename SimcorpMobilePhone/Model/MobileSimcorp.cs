using SimcorpMobile.Model;
using System.Text;

namespace SimcorpMobilePhone.Model {
    public class MobileSimcorp : Mobile {

        public MobileSimcorp(ScreenBase screen, IBattery battery, Keyboard keyboard, Microphone microphone, ISpeaker speaker, SimCard simCard,
            SMSProvider sMSProvider, SMSStorage sMSStorage ) {
            Screen = screen;
            Battery = battery;
            Keyboard = keyboard;
            Microphone = microphone;
            Speaker = speaker;
            SimCard = simCard;
            SMSProvider = SMSProvider;
            SMSStorage = SMSStorage;
        }

        public MobileSimcorp(IBattery battery, Keyboard keyboard, Microphone microphone, SimCard simCard,
            SMSProvider sMSProvider, SMSStorage sMSStorage) {
            Battery = battery;
            Keyboard = keyboard;
            Microphone = microphone;
            SimCard = simCard;
            SMSProvider = SMSProvider;
            SMSStorage = SMSStorage;
        }

        public MobileSimcorp() {
            SMSProvider = new SMSProvider();
        }

        public override void AddContact() { }
        public override void SetRington() { }
        public override void MakeCall() { }
        public override void SendSMS() { }
       
        public override string GetDescription() {
            StringBuilder descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Screen: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard: {Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"Microphone: {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Speaker: {Speaker.ToString()}");
            descriptionBuilder.AppendLine($"Simcard: {SimCard.ToString()}");
            return descriptionBuilder.ToString();
        }
    }
}