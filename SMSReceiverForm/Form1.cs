using SimcorpMobile.Model;
using System;
using System.Windows.Forms;

namespace SMSReceiverForm {
    public partial class Form1 : Form {

        private delegate string FormateDelegate(string text);
        private FormateDelegate Formatter;

        public Form1() {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
        }


        int i = 1;
        SMSStorage SMSStorage = new SMSStorage();
        private void timer1_Tick(object sender, EventArgs e) {
            SimcorpMobile.Model.Message Msg =
                new SimcorpMobile.Model.Message("User" + i, "message #" + i + " received", DateTime.Now);
            OnSMSReceived(Msg.Text);
            SMSStorage.AddMessage(SMSStorage.DataBase, Msg);
            i++;
        }

        //MessageFormatting 
        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                Formatter += MessageFormatting.FormatWithTime;
            } else if (radioButton2.Checked) {
                Formatter = MessageFormatting.FormatWithLowerCase;
            } else if (radioButton3.Checked) {
                Formatter = MessageFormatting.FormatWithUpperCase;
            }
            timer1.Enabled = true;
           
        }
   
        public void OnSMSReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnSMSReceived), message);
                return;
            }

            string formattedMessage = Formatter($"{ message}{ Environment.NewLine}");
            richTextBox1.AppendText(formattedMessage);

        }

        private void button2_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            for (int i = 0; i < SMSStorage.DataBase.Count; i++) {
                if (!comboBox1.Items.Contains(SMSStorage.DataBase[i].User)) {
                    comboBox1.Items.Add(SMSStorage.DataBase[i].User);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
            for (int i = 0; i < SMSStorage.DataBase.Count; i++) {
                richTextBox1.AppendText(SMSStorage.DataBase[i].ToString() + "\n");
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            richTextBox1.Clear();
            string TextToSearch = textBox1.Text;
            string UserSelected = comboBox1.Text;
            DateTime FromTime = dateTimePicker1.Value;
            DateTime ToTime = dateTimePicker2.Value;
            for (int i = 0; i < SMSStorage.DataBase.Count; i++) {
                if (SMSStorage.DataBase[i].Text != null && SMSStorage.DataBase[i].Text.Contains(TextToSearch) &&
                    (comboBox1.SelectedIndex == -1 || SMSStorage.DataBase[i].User.Equals(UserSelected)) &&
                    SMSStorage.DataBase[i].ReceiveTime > FromTime && SMSStorage.DataBase[i].ReceiveTime < ToTime) {
                    richTextBox1.AppendText(SMSStorage.DataBase[i].ToString() + "\n");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {

        }
    }
}
