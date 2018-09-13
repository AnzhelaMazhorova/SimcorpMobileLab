using System;
namespace SimcorpMobilePhone.Model {
    public class ColorfulScreen : ScreenBase { 
        Boolean IsTouchScreen { set; get; }

        public ColorfulScreen(TextOutput output, double screenSize, int dpi, Boolean isTouchScreen) {
            this.Output = output;
            this.ScreenSize = screenSize;
            this.Dpi = dpi;
            this.IsTouchScreen = isTouchScreen;
        }

        public override void DisplayInfo() {
            Output.DataOutput($" {nameof(ColorfulScreen)}");
        }

        public override string ToString() {
            return "Colorful Screen; " + "Screen Size = " + ScreenSize + "; Dpi = " + Dpi +
                (IsTouchScreen ? "; " : "; not") + "Touch screen";
        }
    }
}
