namespace SimcorpMobilePhone.Model {
    public class SensorKeyboard : Keyboard {

        public SensorKeyboard(string language, string keyboardManufacturer) {
            this.Language = language;
            this.KeyboardManufacturer = keyboardManufacturer;
        }

        public override void InputText() { }
        public override string ToString() {
            return Language + " Keyboard; " + "Manufacturer = " + KeyboardManufacturer;
        }
    }
}
