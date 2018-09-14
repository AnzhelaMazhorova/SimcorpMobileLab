namespace SimcorpMobilePhone.Model {
    public interface ISpeaker {
        IOutput Output { get; set; }
        string SpeakerModel { get; set; }
       
        void Play(object data);
    }
}
