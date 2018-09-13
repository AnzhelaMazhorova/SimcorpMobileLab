namespace SimcorpMobilePhone.Model {
    public class Battery : IBattery {
        public int Capacity { get; set; }
        public string BatteryType { get; set; }

        public Battery(int capacity, string batteryType) {
            this.Capacity = capacity;
            this.BatteryType = batteryType;
        }

        public void ChargePhone() { }
        public void ShowPercantage() { }
        public override string ToString() {
            return "Capacity = " + Capacity + "; Type = " + BatteryType;
        }
    }
}
