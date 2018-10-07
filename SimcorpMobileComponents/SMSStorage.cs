using System.Collections.Generic;

namespace SimcorpMobile.Model {
    public class SMSStorage {
        public static List<Message> DataBase = new List<Message>();

        public SMSStorage() {
            DataBase = new List<Message>();
        }

        public delegate void MessageHandler();

        public event MessageHandler MessageAdded;
        public event MessageHandler MessageRemoved;

        public void AddMessage(List<Message> dataBase, Message message) {
            dataBase.Add(message);
            MessageAdded?.Invoke();
        }

        public void RemoveMessage(List<Message> dataBase, Message message) {
            dataBase.Remove(message);
            MessageRemoved?.Invoke();
        }

    }
}
