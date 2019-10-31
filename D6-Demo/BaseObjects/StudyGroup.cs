using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseObjects {
    public class StudyGroup<LL,M> {
        private LL _Leader;  
        private List<M> _Members;
       

        public LL Leader {
            get { return _Leader; }
            set { _Leader = value; }
        }


        public List<M> Members {
            get { return _Members; }
            set { _Members = value; }
        }



    }
}
