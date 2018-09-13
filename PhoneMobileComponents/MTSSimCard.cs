using System;

namespace SimcorpMobilePhone.Model {
    class MTSSimCard : SimCard {
        public SimCardType SimCardType { get; set; }
        public int PinCode { get; set; }

        public MTSSimCard(SimCardType simCardType, int pinCode) {
            this.SimCardType = simCardType;
            this.PinCode = pinCode;
        }

        public override Boolean CheckPin(int code) {
            return false; //TODO
        }

        public override Boolean SetPin(int code) {
            return false; //TODO
        }

        public override string ToString() {
            return "Type = " + SimCardType + "; PinCode = " + PinCode;
        }

    }
}
