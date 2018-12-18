using System;

namespace PartialClass
{
    public partial class Person
    {
        public string LastName { get; set; }

        private string _Position;

        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        public void Speak(int time = 1, int ducation = 1, string what = "Hello")
        {
            //TODO
            HasSpoken(this, EventArgs.Empty);
        }

        public event EventHandler HasSpoken  = delegate { };

        public string GetName()
        {
            return FirstName + " " + LastName;
        }
    }
}
