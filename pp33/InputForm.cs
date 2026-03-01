using System;
using System.Windows.Forms;

namespace pp33
{
    public partial class InputForm : Form
    {
        public string UserInput { get; private set; }

        public InputForm(string prompt, string title = "Ввод", string defaultValue = "")
        {
            InitializeComponent();
            this.Text = title;
            lblPrompt.Text = prompt;
            txtInput.Text = defaultValue;
            txtInput.SelectAll();
            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UserInput = txtInput.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}