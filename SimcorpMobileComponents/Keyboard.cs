namespace SimcorpMobilePhone.Model {
    public abstract class Keyboard {
        public string Language { get; set; }
        public string KeyboardManufacturer { get; set; }

        public abstract void InputText();
    }
}
