namespace SimcorpMobilePhone.Model {
    public interface ISpeaker {
        VoiceOutput Output { get; set; }
        string SpeakerModel { get; set; }
       
        void Play(object data);
    }
}
