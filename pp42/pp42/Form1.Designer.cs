using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pp42
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();

            textBox1.Location = new Point(40, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 25);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            textBox1.BackColor = Color.FromArgb(255, 245, 245);
            textBox1.BorderStyle = BorderStyle.FixedSingle;

            button1.Location = new Point(135, 130);
            button1.Name = "button1";
            button1.Size = new Size(110, 32);
            button1.TabIndex = 3;
            button1.Text = "Проверить";
            button1.Click += button1_Click;
            button1.BackColor = Color.FromArgb(70, 130, 180);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(54, 54, 54);
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 0;
            label1.Text = "Проверка пароля";

            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(100, 100, 100);
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Size = new Size(340, 20);
            label2.TabIndex = 1;
            label2.Text = "минимум 8 символов, нужна хотя бы 1 цифра";

            label3.BackColor = Color.FromArgb(250, 250, 250);
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Consolas", 10F);
            label3.Location = new Point(40, 180);
            label3.Name = "label3";
            label3.Size = new Size(300, 140);
            label3.TabIndex = 4;
            label3.Text = "Результат проверки:";
            label3.TextAlign = ContentAlignment.TopLeft;
            label3.Padding = new Padding(8);

            this.BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(382, 360);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Проверка пароля";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}