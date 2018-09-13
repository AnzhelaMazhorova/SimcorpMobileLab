using System;

namespace SimcorpMobilePhone.Model {
    public class SamsungHeadset : ISpeaker {
        public VoiceOutput Output { get; set; }
        public string SpeakerModel { get; set; }
        private readonly string Manufacturer;

        public SamsungHeadset(VoiceOutput output, string speakerModel, Boolean isWireless) {
            this.Output = output;
            this.SpeakerModel = speakerModel;
            this.Manufacturer = "Samsung";
        }

        public void Play(object data) {
            Output.DataOutput($" {nameof(SamsungHeadset)} sound");
        }
        public override string ToString() {
            return "Manufacturer = " + Manufacturer + "; Model = " + SpeakerModel;
        }
    }
}
