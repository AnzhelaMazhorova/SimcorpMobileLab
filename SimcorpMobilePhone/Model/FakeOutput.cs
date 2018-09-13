using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimcorpMobilePhone.Model {
    public class FakeOutput : IOutput {
        public void DataOutput(string text) {
            return text 
        }
    }
}
