namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // textBoxSearch
            this.textBoxSearch.Location = new System.Drawing.Point(140, 90);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(250, 22);

            // textBoxLink
            this.textBoxLink.Location = new System.Drawing.Point(140, 130);
            this.textBoxLink.Size = new System.Drawing.Size(600, 22);

            // listBoxHistory
            this.listBoxHistory.Location = new System.Drawing.Point(140, 170);
            this.listBoxHistory.Size = new System.Drawing.Size(600, 120);

            // webBrowser1
            this.webBrowser1.Location = new System.Drawing.Point(20, 300);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Size = new System.Drawing.Size(720, 300);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(270, 20);
            this.label1.Text = "ebay search";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 90);
            this.label2.Text = "search";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 130);
            this.label3.Text = "link to search result";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 170);
            this.label4.Text = "Search history";

            // buttonSearch
            this.buttonSearch.Location = new System.Drawing.Point(410, 88);
            this.buttonSearch.Size = new System.Drawing.Size(75, 25);
            this.buttonSearch.Text = "Search";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);

            // buttonBack
            this.buttonBack.Location = new System.Drawing.Point(500, 88);
            this.buttonBack.Size = new System.Drawing.Size(75, 25);
            this.buttonBack.Text = "Back";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);

            // buttonClose
            this.buttonClose.Location = new System.Drawing.Point(320, 610);
            this.buttonClose.Size = new System.Drawing.Size(100, 25);
            this.buttonClose.Text = "Close browser";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(760, 650);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.listBoxHistory);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonClose);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonClose;
    }
}