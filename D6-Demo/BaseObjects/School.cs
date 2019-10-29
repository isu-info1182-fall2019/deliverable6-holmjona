using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseObjects {
  public static class School {
        private static int _Number;
            
        public static int Number {
            get { return _Number; }
            set { _Number = value; }
        }

    }
}
