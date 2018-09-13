using System;

namespace SimcorpMobilePhone.Model {
    public abstract class SimCard {
        SimCardType SimCardType { get; set; }
        int PinCode { get; set; }

        public abstract Boolean CheckPin(int code);
        public abstract Boolean SetPin(int code);
    }
}
