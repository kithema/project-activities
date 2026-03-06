using System;
using System.Windows.Forms;

namespace pp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPurchaseAmount.Text))
                {
                    MessageBox.Show("Введите сумму покупки!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPurchaseAmount.Text, out decimal purchaseAmount) || purchaseAmount < 0)
                {
                    MessageBox.Show("Введите корректную положительную сумму!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal finalAmount = CalculateDiscount(purchaseAmount);
                decimal discountAmount = purchaseAmount - finalAmount;
                int discountPercent = GetDiscountPercent(purchaseAmount);

                lblResult.Text = $"Сумма покупки: {purchaseAmount:C}\n" +
                                $"Скидка: {discountPercent}%\n" +
                                $"Сумма скидки: {discountAmount:C}\n" +
                                $"Итоговая сумма: {finalAmount:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateDiscount(decimal amount)
        {
            if (amount < 1000)
                return amount;
            else if (amount >= 1000 && amount <= 5000)
                return amount * 0.95m; // 5% скидка
            else
                return amount * 0.90m; // 10% скидка
        }

        private int GetDiscountPercent(decimal amount)
        {
            if (amount < 1000)
                return 0;
            else if (amount >= 1000 && amount <= 5000)
                return 5;
            else
                return 10;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPurchaseAmount.Clear();
            lblResult.Text = "Результат будет отображен здесь";
            txtPurchaseAmount.Focus();
        }
    }
}