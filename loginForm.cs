using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace e6dlStandard
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "annoying an causes no issues")]
    public partial class loginForm : Form
    {
        internal static string apiKey;

        public loginForm()
        {
            InitializeComponent();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "annoying an causes no issues")]
        private void loginButton_Click(object sender, EventArgs e)
        {
            apiKey = apiInput.Text;
            ActiveForm.Hide();
        }
    }
}
