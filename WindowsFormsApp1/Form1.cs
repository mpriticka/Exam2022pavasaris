using System;
using System.Windows.Forms;

namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true; // Šī rinda paslēpj kļūdas logus
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Atver eBay lapu, kad palaiž programmu
            webBrowser1.Navigate("https://www.ebay.com");
        }

        private void button1_Click(object sender, EventArgs e) // Search
        {
            string searchTerm = textBoxSearch.Text.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                string searchUrl = $"https://www.ebay.com/sch/i.html?_nkw={Uri.EscapeDataString(searchTerm)}";

                webBrowser1.Navigate(searchUrl);
                textBoxLink.Text = searchUrl;
                listBoxHistory.Items.Add(searchUrl);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Back
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
            else
                webBrowser1.Navigate("https://www.ebay.com");

            textBoxSearch.Text = "";
            textBoxLink.Text = "";
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text;
            if (!string.IsNullOrWhiteSpace(query))
            {
                string url = $"https://www.ebay.com/sch/i.html?_nkw={Uri.EscapeDataString(query)}";
                webBrowser1.Navigate(url);
                textBoxLink.Text = url;
                listBoxHistory.Items.Add(url);
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Atgriežas uz iepriekšējo lapu
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();

            // Izdzēš datus no laukiem
            textBoxSearch.Text = "";
            textBoxLink.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Aizver pārlūkprogrammu, iztīra saturu
            webBrowser1.Navigate("about:blank");
        }

        private void button2_Click(object sender, EventArgs e) // Close browser
        {
            webBrowser1.DocumentText = "<html><body></body></html>";
        }
    }
}
