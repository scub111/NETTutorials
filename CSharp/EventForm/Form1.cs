using System;
using System.Windows.Forms;

namespace EventForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            testClass = new TestClass();
            testClass.ValueChanged += TestClass_ValueChanged;
            //testClass.ValueChanged2();
        }

        private void TestClass_ValueChanged(object sender, MyEventArgs e)
        {
            tbResult.AppendText(string.Format("Valuet was changed - {0} \n", e.Value));
        }

        TestClass testClass;

        private void btnChangeValue_Click(object sender, EventArgs e)
        {
            var value = 0;
            if (int.TryParse(tbValue.Text, out value))
                testClass.Value = value;
            else
                tbResult.AppendText("Incorrect value \n");
        }
    }
}
