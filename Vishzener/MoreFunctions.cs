using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Vishzener
{
    public partial class MoreFunctions : Form
    {
        private StreamReader dictionaryF; // Для подключения словаря
        static string alp = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public int len = alp.Length;
        public double Lc = 0.0529;
        private string template; // Для шаблона расшифрованного текста

        private class Letters : IComparable<Letters> // Класс для частот
        {
            public char letter; // Символ
            public int count; // Количество
            public int num; // Порядок

            public Letters() {} // Конструктор
            public Letters(char l, int c, int n) // Конструктор
            {
                letter = l;
                count = c;
                num = n;
            }
            public int CompareTo(Letters obj) // Для сортировки
            {
                return -1 * this.count.CompareTo(obj.count);
            }
        }

        public MoreFunctions() // Конструктор формы
        {
            InitializeComponent();
        }

        // Получить шифротекст, алфавит, Lcс родительской формы (вызывает родитель)
        public void Initial(string inp, string inAlp, string inLc)
        {
            input.Text = inp;
            alp = inAlp;
            if (inAlp == "") // Если некоректно задано, ставим стандартное значение
            {
                MessageBox.Show("Некорректный алфавит! Выбран стандартный алфавит \'абвгдеёжзийклмнопрстуфхцчшщъыьэюя\'", "Оповещение"); 
                alp = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            }

            if (!double.TryParse(inLc, out Lc)) // Если некоректно задано, ставим стандартное значение
            {
                MessageBox.Show("Некорректное число для Lc! Выбрано ствндартное значение для Lc 0,0529", "Оповещение"); 
                Lc = 0.0529; 
            }
        }

        private double AutoCor(string inp1, int num) // Автокорреляционный метод
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

        private string Decryption(string inp, string key) // Дешифрование
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
            string[][] freq = new string[kLen][]; // Для вывода частот в поле
            Letters[][] lets = new Letters[kLen][]; // Символы для частот

            for (int i = 0; i < kLen; i++)
            {
                lets[i] = new Letters[len];
                for (int j = 0; j < len; j++) // Создание объектов
                    lets[i][j] = new Letters(alp[j], 0, j);

                groups[i] = "";
                for (int j = 0; j < inp.Length; j++) // Разбиение а группы
                    if (j % kLen == i)
                        groups[i] += inp[j];

                for (int j = 0; j < groups[i].Length; j++) // Подсчет частот для каждой группы
                    lets[i][alp.IndexOf(groups[i][j])].count++;

                Array.Sort(lets[i]); // Сортировка
                freq[i] = new string[len];
                for (int j = 0; j < len; j++) // Подготовка строк для записи в поле
                    freq[i][j] += ((j + 1).ToString() + ")" + lets[i][j].letter + "--" + lets[i][j].count + "(" + alp[(alp.IndexOf(lets[i][j].letter) + len - alp.IndexOf('о')) % len] + ")").PadLeft(11);
                // Нахождение ключа
                key += alp[(alp.IndexOf(lets[i][0].letter) + len - alp.IndexOf('о')) % len];
            }

            outKey.Items.Add(key); // Добавление ключа в выпадающее поле

            for (int i = 0; i < len; i++) // Вывод строк частот в поле
            {
                for (int j = 0; j < freq.Length; j++)
                    outFreq.Text += freq[j][i] + "|";
                outFreq.Text += Environment.NewLine; // Переход на новую строку
            }

            outTextGroups.Text += "Текст разбит на " + kLen + " групп:" + Environment.NewLine;
            for (int i = 0; i < kLen; i++) // Вывод строк групп в поле
                outTextGroups.Text += (i + 1).ToString() + ") Размер группы: " + groups[i].Length.ToString() + " " + groups[i] + Environment.NewLine + Environment.NewLine;

            dictionaryF = new StreamReader("ru.dic", Encoding.Default); // Подключение словаря
            string[] dicWords = dictionaryF.ReadToEnd().Split('\n');
            for (int i = 0; i < dicWords.Length; i++)
                dicWords[i] = dicWords[i].Remove(dicWords[i].Length - 1);


            bool valid = false; // временная переменная
            for (int i = 0; i < dicWords.Length; i++) // Взять каждую строку из словаря
            {
                // Если строка меньше длины ключа - пропустить шаг
                if (dicWords[i].Length != kLen) 
                    continue;
                for (int j = 0; j < kLen; j++) // Взять каждый символ строки словаря
                {
                    valid = false;
                    for (int k = 0; k < 8; k++) // Сравнить с каждым символом частот
                    {
                        if (char.ToLower(dicWords[i][j]) == char.ToLower(alp[(alp.IndexOf(lets[j][k].letter) + len - alp.IndexOf('о')) % len]))
                        {
                            valid = true;
                            break;
                        }
                    }
                    if (!valid)
                        break;
                }
                if (valid) // Если строка проходит проверку, добавить в поле и в выпадающий список
                {
                    outKeyVariants.Text += dicWords[i] + Environment.NewLine;
                    outKey.Items.Add(dicWords[i]);
                }
            }
            dictionaryF.Close(); // Закрыть словарь

            return key;
        }

        private int KeyLengthSeek(string inp) // Поиск длины ключа
        {
            double temp;
            int size = inp.Length < len ? inp.Length : len;
            outMethod1.Text = "Lc для разных длин:" + Environment.NewLine;
            outMethod2.Text = "Lc для разных длин:" + Environment.NewLine;
            
            for (int i = 1; i < size; i++) // Запустить метод каждой n-ной буквы
            {
                temp = AntiCor(inp, i);
                // Записать результат в поле
                outMethod1.Text += "Для " + i + " Lc: " + temp.ToString("G6") + Environment.NewLine;

                if (temp > Lc || Math.Abs(temp - Lc) < 0.005)
                {
                    outKeySize1.Text = i.ToString();
                    break;
                }
            }

            for (int i = 1; i < size; i++) // Запустить автокорреляционный метод
            {
                temp = AutoCor(inp, i);
                // Записать результат в поле
                outMethod2.Text += "Для " + i + " Lc: " + temp.ToString("G6") + Environment.NewLine;

                if (temp > Lc || Math.Abs(temp - Lc) < 0.005)
                {
                    outKeySize2.Text = i.ToString();
                    return i;
                }
            }

            return 0;
        }

        // Отбросить из строки все символы, которых нету в алфавите
        private string RewriteStr(string inp)
        {
            string result = "";

            for (int i = 0; i < inp.Length; i++)
                if (alp.Contains(char.ToLower(inp[i])))
                    result += char.ToLower(inp[i]);

            return result;
        }

        // Вернуть первоначальный вид строки (по шаблону)
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

        private void KeySizeBut_Click(object sender, EventArgs e) // Обработка кнопки
        {
            outKeySize1.Text = "";
            outKeySize2.Text = "";
            outMethod1.Text = "";
            outMethod2.Text = "";
            template = input.Text;
            string inp = RewriteStr(template);
            if (inp == "")
                return;
            KeyLengthSeek(inp);

        }

        private void SeekKeyBut_Click(object sender, EventArgs e) // Обработка кнопки
        {
            template = input.Text;
            string inp = RewriteStr(template);
            if (inp == "")
                return;
            outFreq.Text = "";
            outKeyVariants.Text = "";
            outKey.Items.Clear();
            string key = KeySeek(inp, KeyLengthSeek(inp));
            outKey.Text = key;
        }

        private void DecryptBut_Click(object sender, EventArgs e) // Обработка кнопки
        {
            string key = RewriteStr(outKey.Text);
            if (key == "") { MessageBox.Show("В строке ключа символы должны соответствовать алфавиту!", "Ошибка"); return; }
            template = input.Text;
            string inp = RewriteStr(template);
            output.Text = RecoverStr(Decryption(inp, key), template);
        }

        private void clearBut_Click(object sender, EventArgs e) // Обработка кнопки
        {
            input.Text = "";
            output.Text = "";
            outFreq.Text = "";
            outKey.Text = "";
            outKey.Items.Clear();
            outKeySize1.Text = "";
            outKeySize2.Text = "";
            outKeyVariants.Text = "";
            outMethod1.Text = "";
            outMethod2.Text = "";
            outTextGroups.Text = "";
        }
    }
}
