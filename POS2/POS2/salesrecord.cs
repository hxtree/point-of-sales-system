using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;



namespace POS2
{
    class salesrecord
    {
        private ArrayList _salesRecord = new ArrayList();

        public ArrayList salesRecord
        {
            get
            {
                return _salesRecord;
            }
            set
            {
                _salesRecord = value;
            }
        }

    }
}
