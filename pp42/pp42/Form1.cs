using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pp42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckPasswordLength(string password)
        {
            return password.Length >= 8;
        }

        private bool CheckPasswordDigits(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        private string ShowPasswordStrength(string password)
        {
            bool hasLength = CheckPasswordLength(password);
            bool hasDigits = CheckPasswordDigits(password);

            if (hasLength && hasDigits)
            {
                return "Надёжный";
            }
            else if (hasLength || hasDigits)
            {
                return "Средний";
            }
            else
            {
                return "Слабый";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;

            bool lengthOk = CheckPasswordLength(password);
            string lengthOkStr;
            if (lengthOk == true)
            {
                lengthOkStr = "Правильная";
            }
            else
            {
                lengthOkStr = "Неправильная (минимум 8 символов)";
            }

            bool digitsOk = CheckPasswordDigits(password);
            string digitsOkStr;
            if (digitsOk == true)
            {
                digitsOkStr = "Есть";
            }
            else
            {
                digitsOkStr = "Нет";
            }

            string strength = ShowPasswordStrength(password);

            label3.Text = $"Длина пароля: {lengthOkStr}\n" +
                         $"Наличие цифр: {digitsOkStr}\n" +
                         $"Надежность: {strength}";
        }

    }
}