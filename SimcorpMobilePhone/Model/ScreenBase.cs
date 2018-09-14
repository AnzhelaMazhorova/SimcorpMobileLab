namespace SimcorpMobilePhone.Model {
    public  abstract class ScreenBase {
        public IOutput Output { get; set; }
        public double ScreenSize { get; set; }
        public int Dpi { get; set; }

        public abstract void DisplayInfo();
    }
}
