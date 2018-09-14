using System;

namespace SimcorpMobilePhone.Model {
    public class PhoneSpeaker : ISpeaker {
        public IOutput Output { get; set; }
        public string SpeakerModel { get; set; }

        public PhoneSpeaker(IOutput output, string speakerModel) {
            this.Output = output;
            this.SpeakerModel = speakerModel;
        }

        public void Play(object data) {
            Output.DataOutput($" {nameof(PhoneSpeaker)} sound");
        }

        public override string ToString() {
            return "Model = " + SpeakerModel;
        }
    }
}
