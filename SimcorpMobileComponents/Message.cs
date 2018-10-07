using System;

namespace SimcorpMobile.Model {
    public class Message {
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceiveTime { get; set; }

        public Message(string user, string text, DateTime receiveTime) {
            User = user;
            Text = text;
            ReceiveTime = receiveTime;
        }

        public override string ToString() {
            return ReceiveTime + "; " + User + "; '" + Text + "' ";
        }

    }
}
