using System;

namespace SimcorpMobilePhone.Model {
    public class PhoneSpeaker : ISpeaker {
        public VoiceOutput Output { get; set; }
        public string SpeakerModel { get; set; }

        public PhoneSpeaker(VoiceOutput output, string speakerModel) {
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
