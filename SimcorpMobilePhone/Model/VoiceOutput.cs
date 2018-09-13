using System;
using System.Speech.Synthesis;

namespace SimcorpMobilePhone.Model {
    public class VoiceOutput : IOutput {
       
        public void DataOutput(string text) {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(text);
        }
    }
}
