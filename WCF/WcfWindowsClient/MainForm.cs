using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WcfWindowsClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bntGetData_Click(object sender, EventArgs e)
        {
            try
            {
                var watch = new Stopwatch();
                watch.Start();
                var _obj = new ServiceReference1.Service1Client();
                watch.Stop();
                txtResult.Text = $"Result -> {_obj.GetData((int)numValue.Value)} in {watch.ElapsedMilliseconds:0} ms";

            }
            catch (Exception ex)
            {
                txtResult.Text = $"{ex.Source}: {ex.Message}";
            }
        }
    }
}
