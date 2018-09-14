namespace SimcorpMobilePhone.Model {
    public class MonochromeScreen : ScreenBase {

        public MonochromeScreen(IOutput output, double screenSize, int dpi) {
            this.Output = output;
            this.ScreenSize = screenSize;
            this.Dpi = dpi;
        }

        public override void DisplayInfo() {
            Output.DataOutput($" {nameof(MonochromeScreen)}");
        }

        public override string ToString() {
            return "Monochrome Screen";
        }
    }
}
