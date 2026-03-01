using System;
using System.Drawing;
using System.Windows.Forms;

namespace pp33
{
    public partial class Form1 : Form
    {
        private TextBox txtOutput;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Задачи по массивам — Уровень 1 и 2";
            this.Size = new System.Drawing.Size(740, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            txtOutput = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = true,
                Location = new System.Drawing.Point(12, 180),
                Size = new System.Drawing.Size(700, 380),
                Font = new System.Drawing.Font("Consolas", 10f),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            this.Controls.Add(txtOutput);

            AddTaskButton("Задача 1: Сумма 10 чисел", 12, 12, Task1_Sum);
            AddTaskButton("Задача 2: Max/Min + индексы", 180, 12, Task2_MaxMin);
            AddTaskButton("Задача 3: Чётные/нечётные", 348, 12, Task3_EvenOdd);
            AddTaskButton("Задача 4: Реверс (два способа)", 12, 60, Task4_Reverse);
            AddTaskButton("Задача 5: Сдвиг вправо", 180, 60, Task5_ShiftRight);
            AddTaskButton("Задача 6: Подсчёт повторов", 348, 60, Task6_CountDuplicates);
        }

        private void AddTaskButton(string text, int x, int y, EventHandler handler)
        {
            Button btn = new Button
            {
                Text = text,
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(160, 40),
                Font = new System.Drawing.Font("Segoe UI", 9.5f, FontStyle.Regular)
            };
            btn.Click += handler;
            this.Controls.Add(btn);
        }

        // ───────────────────────────────────────────────
        // Универсальный ввод вместо InputBox
        // ───────────────────────────────────────────────
        private string GetUserInput(string prompt, string title = "Ввод", string defaultValue = "")
        {
            using (var form = new InputForm(prompt, title, defaultValue))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                    return form.UserInput.Trim();
                return null;
            }
        }

        // ───────────────────────────────────────────────
        // Задача 1
        // ───────────────────────────────────────────────
        private void Task1_Sum(object sender, EventArgs e)
        {
            txtOutput.Clear();
            int[] arr = new int[10];
            long sum = 0;

            txtOutput.AppendText("Задача 1. Введите 10 целых чисел:\r\n\r\n");

            for (int i = 0; i < 10; i++)
            {
                string input = GetUserInput($"Число #{i + 1}:", "Задача 1");
                if (input == null || !int.TryParse(input, out arr[i]))
                {
                    MessageBox.Show("Некорректный ввод → будет 0", "Ошибка");
                    arr[i] = 0;
                }
                sum += arr[i];
            }

            txtOutput.AppendText("Массив: " + string.Join(" ", arr) + "\r\n");
            txtOutput.AppendText($"\r\nСумма = {sum}\r\n");
        }

        // ───────────────────────────────────────────────
        // Задача 2
        // ───────────────────────────────────────────────
        private void Task2_MaxMin(object sender, EventArgs e)
        {
            txtOutput.Clear();

            string s = GetUserInput("Размер массива N:", "Задача 2", "8");
            if (s == null || !int.TryParse(s, out int n) || n < 1)
            {
                MessageBox.Show("Некорректный размер", "Ошибка");
                return;
            }

            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++) arr[i] = rnd.Next(1, 101);

            int minVal = arr[0], maxVal = arr[0];
            int minIdx = 0, maxIdx = 0;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] < minVal) { minVal = arr[i]; minIdx = i; }
                if (arr[i] > maxVal) { maxVal = arr[i]; maxIdx = i; }
            }

            txtOutput.AppendText($"Массив ({n} элементов):\r\n" + string.Join(" ", arr) + "\r\n\r\n");
            txtOutput.AppendText($"Минимум: {minVal} (индекс {minIdx})\r\n");
            txtOutput.AppendText($"Максимум: {maxVal} (индекс {maxIdx})\r\n");
        }

        // ───────────────────────────────────────────────
        // Задача 3
        // ───────────────────────────────────────────────
        private void Task3_EvenOdd(object sender, EventArgs e)
        {
            txtOutput.Clear();

            int[] arr = new int[15];
            Random rnd = new Random();
            int even = 0, odd = 0;

            for (int i = 0; i < 15; i++)
            {
                arr[i] = rnd.Next(10, 51);
                if (arr[i] % 2 == 0) even++;
                else odd++;
            }

            txtOutput.AppendText("Массив (15 элементов, 10–50):\r\n" + string.Join(" ", arr) + "\r\n\r\n");
            txtOutput.AppendText($"Чётных: {even}\r\nНечётных: {odd}\r\n");
        }

        // ───────────────────────────────────────────────
        // Задача 4
        // ───────────────────────────────────────────────
        private void Task4_Reverse(object sender, EventArgs e)
        {
            txtOutput.Clear();

            int[] original = new int[5];

            for (int i = 0; i < 5; i++)
            {
                string s = GetUserInput($"Элемент #{i + 1}:", "Задача 4");
                if (s == null || !int.TryParse(s, out original[i]))
                    original[i] = 0;
            }

            int[] reversed = new int[5];
            for (int i = 0; i < 5; i++)
                reversed[i] = original[4 - i];

            int[] inplace = (int[])original.Clone();
            Array.Reverse(inplace);

            txtOutput.AppendText("Исходный массив:  " + string.Join(" ", original) + "\r\n");
            txtOutput.AppendText("Новый (реверс):    " + string.Join(" ", reversed) + "\r\n");
            txtOutput.AppendText("Разворот на месте: " + string.Join(" ", inplace) + "\r\n");
        }

        // ───────────────────────────────────────────────
        // Задача 5
        // ───────────────────────────────────────────────
        private void Task5_ShiftRight(object sender, EventArgs e)
        {
            txtOutput.Clear();

            int[] arr = { 10, 20, 30, 40, 50 };

            txtOutput.AppendText("До сдвига:  " + string.Join(" ", arr) + "\r\n");

            int last = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
                arr[i] = arr[i - 1];
            arr[0] = last;

            txtOutput.AppendText("После сдвига вправо: " + string.Join(" ", arr) + "\r\n");
        }

        // ───────────────────────────────────────────────
        // Задача 6
        // ───────────────────────────────────────────────
        private void Task6_CountDuplicates(object sender, EventArgs e)
        {
            txtOutput.Clear();

            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                string s = GetUserInput($"Число #{i + 1}:", "Задача 6");
                if (s == null || !int.TryParse(s, out arr[i]))
                    arr[i] = 0;
            }

            txtOutput.AppendText("Массив: " + string.Join(" ", arr) + "\r\n\r\n");

            bool[] processed = new bool[10];

            for (int i = 0; i < 10; i++)
            {
                if (processed[i]) continue;

                int count = 1;
                for (int j = i + 1; j < 10; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        processed[j] = true;
                    }
                }

                txtOutput.AppendText($"Число {arr[i]} встречается {count} раз\r\n");
                processed[i] = true;
            }
        }
    }
}