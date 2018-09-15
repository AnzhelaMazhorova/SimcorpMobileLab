namespace SimcorpMobilePhone.Model {
    public class TestOutput : IOutput {

        public string DataOutputTest;

        public void DataOutput(string text) {
            this.DataOutputTest = text;
        }
    }
}
