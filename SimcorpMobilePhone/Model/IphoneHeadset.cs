using System;

namespace SimcorpMobilePhone.Model {
    public class IphoneHeadset : ISpeaker {
        public IOutput Output { get; set; }
        public string SpeakerModel { get; set; }
        private readonly string Manufacturer;

        public IphoneHeadset(IOutput output, string speakerModel, Boolean isWireless) {
            Output = output;
            SpeakerModel = speakerModel;
            Manufacturer = "Iphone";
        }

        public void Play(object data) {
            Output.DataOutput($" {nameof(IphoneHeadset)} sound");
        }

        public override string ToString() {
            return "Manufacturer = " + Manufacturer + "; Model = " + SpeakerModel;
        }
    }
}
