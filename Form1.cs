using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Form1 // Changed namespace to Form1
{
    public partial class WebViewForm : Form // Changed class name to WebViewForm
    {
        public WebViewForm() // Constructor updated to match class name
        {
            InitializeComponent();
        }

        private async void WebViewForm_Load(object sender, EventArgs e) // Updated event handler
        {
            // Ensure the WebView2 environment is created
            await webView21.EnsureCoreWebView2Async(null);
            // Navigate to a specific URL
            webView21.Source = new Uri("https://duck.ai");
        }
    }
}
