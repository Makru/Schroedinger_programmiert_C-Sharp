using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterValidation {
    public class SchroedingerException : Exception {
        public string Zusatzinfos { get; set; }
    }
}
