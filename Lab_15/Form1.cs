using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

      
        //Завдання 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double x))

            {  
                if (x == 0)
                {
                    textBox2.Text = "Не визначено";
                    return;
                }


                double rezult = Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + x * x);
                textBox2.Text = rezult.ToString();


            }
            
            else
            {
               MessageBox.Show("Будь ласка, введіть коректне число у textbox1", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Завдання 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double a) &&
                double.TryParse(textBox4.Text, out double b) &&
                double.TryParse(textBox5.Text, out double angle))
            {
                double area = a * b * Math.Sin(angle * Math.PI / 180) / 2;

                textBox6.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Завдання 3
        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox7.Text, out double a) &&
                double.TryParse(textBox8.Text, out double b) &&
                double.TryParse(textBox9.Text, out double c) &&
                double.TryParse(textBox10.Text, out double d))

            {
                bool areSimilar = (a / c == b / d) || (a / d == b / c);

                textBox11.Text = areSimilar.ToString();
            }

            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Завдання 4
        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox12.Text, out double num1) &&
                double.TryParse(textBox13.Text, out double num2) &&
                double.TryParse(textBox14.Text, out double num3))
            {
                bool Positiveornot = (num1 + num2) > 0 || (num2 + num3) > 0 || (num3 + num1) > 0;
                textBox15.Text = Positiveornot.ToString();
            }

            else
            {
                MessageBox.Show("Будь ласка, введіть коректні значення у всі текстові поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Завдання 5
        private void button5_Click(object sender, EventArgs e)
        {
            for (int age = 100; age <= 150; age++)
            {
                for (int bDay = 1; bDay < 31; bDay++)
                {
                    int SuMM = CalculateSumOfSquares(age) + bDay;

                    if (SuMM == age)
                    {
                        label21.Text = $"Довгожитель має вік {age} років і день народження {bDay}.";
                        return;
                    }
                }
            }

        }

        // Метод для обчислення суми квадратів цифр числа
        private int CalculateSumOfSquares(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit * digit;
                number /= 10;
            }
            return sum;
        }

        //Завдання 6
        private void button6_Click(object sender, EventArgs e)
        {
            string[] aSequence = textBox16.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] bSequence = textBox17.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (aSequence.Length != bSequence.Length)
            {
                MessageBox.Show("Послідовності повинні мати однакову довжину.");
                return;
            }

            for (int i = 0; i < aSequence.Length; i++)
            {
                int aValue, bValue;
                if (int.TryParse(aSequence[i], out aValue) && int.TryParse(bSequence[i], out bValue))
                {
                    if (aValue <= 0)
                    {
                        bValue *= 10;
                    }
                    else
                    {
                        bValue = 0;
                    }
                    bSequence[i] = bValue.ToString();
                }
                else
                {
                    MessageBox.Show("Помилка при обробці чисел в позиції " + (i + 1) + ".");
                    return;
                }
            }

            textBox17.Text = string.Join(" ", bSequence);
        }

        //Завдання 7
        private void button7_Click(object sender, EventArgs e)
        {
            string inputString = textBox18.Text;
            string group = "abc";
            int count = Regex.Matches(inputString, group).Count;
            textBox19.Text = count.ToString();
        }
    }
}
 
