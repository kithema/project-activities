using System.Drawing;
using System.Windows.Forms;

namespace pp43
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();

            textBox1.Location = new Point(140, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;

            button1.Location = new Point(125, 190);
            button1.Name = "button1";
            button1.Size = new Size(130, 35);
            button1.TabIndex = 5;
            button1.Text = "Конвертировать";
            button1.Click += button1_Click;

            radioButton1.Location = new Point(80, 110);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(220, 25);
            radioButton1.TabIndex = 3;
            radioButton1.Text = "Цельсий -> Фаренгейт";
            radioButton1.Checked = true;

            radioButton2.Location = new Point(80, 140);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(220, 25);
            radioButton2.TabIndex = 4;
            radioButton2.Text = "Фаренгейт -> Цельсий";

            label1.Location = new Point(100, 30);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 0;
            label1.Text = "Температура:";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 2;
            label2.Visible = false;

            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(40, 240);
            label3.Name = "label3";
            label3.Size = new Size(300, 60);
            label3.TabIndex = 7;
            label3.Text = "0.00";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.BackColor = Color.White;

            ClientSize = new Size(380, 320);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(button1);
            Controls.Add(label3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Конвертер температур";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}