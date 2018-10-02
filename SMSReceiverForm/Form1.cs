using SimcorpMobileComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSReceiverForm {
    public partial class Form1 : Form {
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
        private void timer1_Tick(object sender, EventArgs e) {
            OnSMSReceived("message #" + i + " received");
            i++;
        }

        private delegate string FormateDelegate(string text);
        private FormateDelegate Formatter;

        private void button1_Click(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                Formatter = new FormateDelegate(SMSProvider.FormatWithTime);
            } else if (radioButton2.Checked) {
                Formatter = new FormateDelegate(SMSProvider.FormatWithLowerCase);
            } else if (radioButton3.Checked) {
                Formatter = new FormateDelegate(SMSProvider.FormatWithUpperCase);
            }
            timer1.Enabled = true;
           
        }

        private void OnSMSReceived(string message) {
            if (InvokeRequired) {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnSMSReceived), message);
                return;
            }

            string formattedMessage = Formatter($"{ message}{ Environment.NewLine}");
            richTextBox1.AppendText(formattedMessage);

        }

    }
}
