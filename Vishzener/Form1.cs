using System;
using System.Linq;
using System.Windows.Forms;

namespace Vishzener
{
    public partial class Form1 : Form
    {
        static string alp = ""; 
        public int len;
        public double Lc;
        private bool enc = true;  // Шифрование - true, дешифрование - false
        private bool autoC = true; // Автокорреляционный метод - true, другой - false
        private MoreFunctions more; // Форма расширенных функций

        class Letters : IComparable<Letters> // Класс для частот символов
        {
            public char letter; // Символ
            public int count; // Количество
            public int num; // Порядок
            public Letters(char l, int c, int n) // Конструктор
            { 
                letter = l; 
                count = c; 
                num = n; 
            }
            public int CompareTo(Letters obj) // Для сортировки
            {
                return -1*this.count.CompareTo(obj.count);
            }
        }

        public Form1() // Конструктор формы
        {
            InitializeComponent();
        }

        private double AutoCor(string inp1, int num) // Автокоррелционный метод
        {
            int size = inp1.Length;
            string inp2 = "";
            int n = 0;
            inp2 += inp1.Substring(num) + inp1.Substring(0, num);

            for (int i = 0; i < size; i++)
                if (char.ToLower(inp1[i]) == char.ToLower(inp2[i]))
                    n++;

            return (double)n / size;
        }

        private double AntiCor(string inp, int n) // Метод каждой n-ной буквы
        {
            double result = 0;
            string temp = "";
            int[] amLet = new int[len];

            for (int i = 0; i < inp.Length; i += n)
                temp += inp[i];

            for (int i = 0; i < temp.Length; i++)
                if (alp.Contains(temp[i]))
                    amLet[alp.IndexOf(temp[i])]++;

            for (int i = 0; i < len; i++)
                result += (double)(amLet[i] * (amLet[i] - 1)) / (temp.Length * (temp.Length - 1));

            return result;
        }

        private string Encryption(string inp, string key) // Шифрование
        {
            string result = "";

            for (int i = 0; i < inp.Length; i++)
                result += alp[(alp.IndexOf(inp[i]) + alp.IndexOf(key[i % key.Length])) % len];

            return result;
        }

        private string Decryption(string inp, string key) // Дешифроваие
        {
            string result = "";

            for (int i = 0; i < inp.Length; i++)
                result += alp[(alp.IndexOf(inp[i]) + len - alp.IndexOf(key[i % key.Length])) % len];

            return result;
        }

        private string KeySeek(string inp, int kLen) // Поиск ключа
        {
            string key = "";

            string[] groups = new string[kLen]; // Строки подтекстов
            Letters[][] lets = new Letters[kLen][]; // Для частот

            for (int i = 0; i < kLen; i++)
            {
                lets[i] = new Letters[len];
                for (int j = 0; j < len; j++) // Создание объектов
                    lets[i][j] = new Letters(alp[j], 0, j);

                groups[i] = "";
                for (int j = 0; j < inp.Length; j++) // Разбиение на группы
                    if (j % kLen == i)
                        groups[i] += inp[j];

                for (int j = 0; j < groups[i].Length; j++) // Подсчет частот
                    lets[i][alp.IndexOf(groups[i][j])].count++;

                Array.Sort(lets[i]); // Сортировка
                // Нахождение ключа
                key += alp[(alp.IndexOf(lets[i][0].letter) + len - alp.IndexOf('о')) % len];
            }
            
            return key;
        }

        private int KeyLengthSeek(string inp) // Поиск длины ключа
        {
            double temp;
            int size = inp.Length < len ? inp.Length : len;
            keyText.Text = "";

            for (int i = 1; i < size; i++)
            {
                // Запомнить результат в зависимости от выбранного метода
                temp = autoC ? AutoCor(inp, i) : AntiCor(inp, i);
                // Записать в поле
                keyText.Text += "Для длины ключа " + i + " Lc: " + temp.ToString("G4") + Environment.NewLine;

                if (temp > Lc || Math.Abs(temp - Lc) < 0.005)
                    return i;
            }
            return 0;
        }

        // Отбросить ненужные символы строки
        private string RewriteStr(string inp)
        {
            string result = "";

            for (int i = 0; i < inp.Length; i++)
                if (alp.Contains(char.ToLower(inp[i])))
                    result += char.ToLower(inp[i]);

            return result;
        }

        // Восстановить прежний вид строки по шаблону
        private string RecoverStr(string inp, string temp)
        {
            string result = "";
            int k = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (!alp.Contains(char.ToLower(temp[i])))
                    result += temp[i];
                else if (char.IsUpper(temp[i]))
                    result += char.ToUpper(inp[k++]);
                else result += inp[k++];
            }

            return result;
        }

        private void Button1_Click(object sender, EventArgs e) // Обработка кнопки
        {
            alp = inpAlp.Text;
            len = alp.Length;
            string key;
            string inp;
            string template = input.Text;
            int keyLen;
            inp = RewriteStr(template);
            if (enc)
            {
                if (alp == "") { MessageBox.Show("Невозможна работа с пустым алфавитом!", "Ошибка"); inpAlp.Text = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; return; }
                key = inpKey.Text;
                key = RewriteStr(key);
                inpKey.Text = key;
                if (key == "") { MessageBox.Show("В строке ключа символы должны соответствовать алфавиту!", "Ошибка"); return; }
                output.Text = RecoverStr(Encryption(inp, key), template);
            }
            else
            {
                if (alp == "") { MessageBox.Show("Невозможна работа с пустым алфавитом!", "Ошибка"); inpAlp.Text = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; return; }
                if (!double.TryParse(inpLc.Text, out Lc)) { MessageBox.Show("Неправильно задано число для Lc!", "Ошибка"); inpLc.Text = "0,0529"; return; }
                keyLen = KeyLengthSeek(inp);
                lbKNum.Text = keyLen.ToString();
                key = KeySeek(inp, keyLen);
                inpKey.Text = key;
                //key = inpKey.Text;
                output.Text = RecoverStr(Decryption(inp, key), template);
            }
        }
        private void Input_TextChanged(object sender, EventArgs e) // Обработка изменения текста
        {
            lbTNum.Text = input.Text.Length.ToString();
            output.Text = "";
        }

        private void Output_TextChanged(object sender, EventArgs e) // Обработка изменения текста
        {
            lbRNum.Text = output.Text.Length.ToString();
        }

        private void InpAlp_TextChanged(object sender, EventArgs e) // Обработка изменения текста
        {
            lbANum.Text = inpAlp.Text.Length.ToString();
        }

        private void RB1_CheckedChanged(object sender, EventArgs e) // Обработка radioButton
        {
            if(!enc)
            {
                enc = true;
                Width = 530;
                input.Text = "";
                output.Text = "";
                inpKey.Text = "";
            }
        }

        private void RB2_CheckedChanged(object sender, EventArgs e) // Обработка radioButton
        {
            if(enc)
            {
                enc = false;
                Width = 830;
                input.Text = "";
                output.Text = "";
                inpKey.Text = "";
                keyText.Text = "";
                lbKNum.Text = "";
            }
        }

        private void RBAntiC_CheckedChanged(object sender, EventArgs e) // Обработка radioButton
        {
            autoC = false;
        }

        private void RBAutoC_CheckedChanged(object sender, EventArgs e) // Обработка radioButton
        {
            autoC = true;
        }

        private void Button1_Click_1(object sender, EventArgs e) // Обработка кнопки
        {
            if (output.Text != "")
                Clipboard.SetText(output.Text);
        }

        private void Button2_Click(object sender, EventArgs e) // Обработка кнопки
        {
            input.Text = "";
            output.Text = "";
            inpKey.Text = "";
            keyText.Text = "";
            lbKNum.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e) // Обработка кнопки
        {
            if (more != null)
                more.Close();
            more = new MoreFunctions();
            more.Initial(input.Text, inpAlp.Text, inpLc.Text);
            more.Show();
        }
    }
}