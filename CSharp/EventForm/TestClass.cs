using System;

namespace EventForm
{
    public class TestClass
    {
        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                if (_value == value)
                    return;
                _value = value;
                ValueChanged(this, new MyEventArgs(_value));
            }
        }

        public event EventHandler<MyEventArgs> ValueChanged = delegate { };

        public EventHandler ValueChanged2 = delegate { };
    }

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}
