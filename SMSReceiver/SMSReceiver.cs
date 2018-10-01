using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSReceiver {
    public partial class SMSReceiver : Form {
        public SMSReceiver() {
            InitializeComponent();
        }

        private delegate string FormateDelegate(string text);
        private readonly FormateDelegate Formatter;

    }
}
