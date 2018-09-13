using System;

namespace SimcorpMobilePhone.Model {
    public class TextOutput : IOutput {

        public void DataOutput(string text) {
            Console.WriteLine(text); 
        }
    }
}
