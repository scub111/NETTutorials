using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Task<string> DowloadSomething()
        {
            /*
            return Task<string>.Factory.StartNew(() =>
            {
                Thread.Sleep(3000); // Имитация длительной обработки...
                return "Результат обработки";
            });
            */
            var task = new Task<string>(() =>
            {
                Thread.Sleep(3000); // Имитация длительной обработки...
                return "Результат обработки";
            });
            task.Start();
            return task;
        }

        private async void btnGetHTTP_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            /*
            using (var httpClient = new HttpClient())
            {
                tbResult.Text = await httpClient.GetStringAsync("http://www.microsoft.com");
            }
            */
            /*
            tbResult.Text = await Task<string>.Factory.StartNew(() =>
            {
                Thread.Sleep(2000); // Имитация длительной обработки...
                return "Результат обработки";
            });
            */
            tbResult.Text = await DowloadSomething();
        }

        private async void btnDelay_Click(object sender, EventArgs e)
        {
            btnDelay.Text = "Start delay function...";
            await DelayFunction();
            btnDelay.Text = "Done";
        }

        private async Task DelayFunction()
        {
            await Task.Delay(3000);
        }
    }
}
