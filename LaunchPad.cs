using System;
using System.Windows.Forms;
using Noppes.E621;
using Noppes.E621.Converters;

namespace e6dlStandard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.ShowDialog();
            urlLabel.Hide();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "annoying an causes no issues")]
        private async void searchButton_Click(object sender, EventArgs e)
        {

            var e6dlClient = new E621ClientBuilder()
                .WithUserAgent("E6DL Standard", "v0.1.0", "@0Foxpal", "Foxpal (Derogatory)")
                .WithMaximumConnections(E621Client.MaximumConnectionsLimit)
                .WithRequestInterval(E621Client.MinimumRequestInterval)
                .Build();

            bool success = await e6dlClient.LogInAsync("Foxpal", loginForm.apiKey);

            if(success == true)
            {
                var posts = await e6dlClient.GetPostsAsync(Convert.ToString(tagBox), limit: 1);
                
            }
            else
            {
                MessageBox.Show("this is a test message indicating failure");
            }

        }
    }
}
