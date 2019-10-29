using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseObjects {
    public class Desk<T> {
        private T _Sitter;

        public T Sitter {
            get { return _Sitter; }
            set { _Sitter = value; }
        }

    }
}
