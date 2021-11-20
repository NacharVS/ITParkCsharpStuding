using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkStuding
{
    class DelegatesEvents
    {
        public delegate void ValueChangedDelegate(int a);

        private int _number;

        public static double taxRate { get; set; } = 0.67;
        public double deposit { get; set; }

        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                //ValueChangedEvent?.Invoke(_number);
                if (ValueChangedEvent != null)
                    ValueChangedEvent.Invoke(_number);
            }
        }

        public event ValueChangedDelegate ValueChangedEvent;
    }
}
