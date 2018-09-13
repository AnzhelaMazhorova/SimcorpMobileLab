namespace SimcorpMobilePhone.Model {
    public interface IBattery {
        int Capacity { get; set; }
        string BatteryType { get; set; }

        void ChargePhone();
        void ShowPercantage();
    }
}
