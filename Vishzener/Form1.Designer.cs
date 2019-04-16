namespace Vishzener
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.inpKey = new System.Windows.Forms.TextBox();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbRNum = new System.Windows.Forms.Label();
            this.inpAlp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbANum = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbKNum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.inpLc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBAutoC = new System.Windows.Forms.RadioButton();
            this.rBAntiC = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Алфавит: ";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(12, 75);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input.Size = new System.Drawing.Size(500, 140);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runBtn.Location = new System.Drawing.Point(11, 395);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(52, 32);
            this.runBtn.TabIndex = 2;
            this.runBtn.Text = "RUN!";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(12, 242);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(500, 140);
            this.output.TabIndex = 3;
            this.output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // inpKey
            // 
            this.inpKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inpKey.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpKey.Location = new System.Drawing.Point(75, 18);
            this.inpKey.Name = "inpKey";
            this.inpKey.Size = new System.Drawing.Size(191, 29);
            this.inpKey.TabIndex = 4;
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Checked = true;
            this.rB1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB1.Location = new System.Drawing.Point(380, 5);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(119, 24);
            this.rB1.TabIndex = 5;
            this.rB1.TabStop = true;
            this.rB1.Text = "Шифрование";
            this.rB1.UseVisualStyleBackColor = true;
            this.rB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rB2.Location = new System.Drawing.Point(380, 29);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(128, 24);
            this.rB2.TabIndex = 6;
            this.rB2.TabStop = true;
            this.rB2.Text = "Криптоанализ";
            this.rB2.UseVisualStyleBackColor = true;
            this.rB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(377, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Размер текста:";
            // 
            // lbTNum
            // 
            this.lbTNum.AutoSize = true;
            this.lbTNum.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTNum.Location = new System.Drawing.Point(471, 55);
            this.lbTNum.Name = "lbTNum";
            this.lbTNum.Size = new System.Drawing.Size(15, 17);
            this.lbTNum.TabIndex = 0;
            this.lbTNum.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(382, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Размер текста:";
            // 
            // lbRNum
            // 
            this.lbRNum.AutoSize = true;
            this.lbRNum.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRNum.Location = new System.Drawing.Point(475, 223);
            this.lbRNum.Name = "lbRNum";
            this.lbRNum.Size = new System.Drawing.Size(15, 17);
            this.lbRNum.TabIndex = 0;
            this.lbRNum.Text = "0";
            // 
            // inpAlp
            // 
            this.inpAlp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpAlp.Location = new System.Drawing.Point(159, 398);
            this.inpAlp.Name = "inpAlp";
            this.inpAlp.Size = new System.Drawing.Size(314, 29);
            this.inpAlp.TabIndex = 4;
            this.inpAlp.Text = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            this.inpAlp.TextChanged += new System.EventHandler(this.InpAlp_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ключ: ";
            // 
            // lbANum
            // 
            this.lbANum.AutoSize = true;
            this.lbANum.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbANum.Location = new System.Drawing.Point(479, 401);
            this.lbANum.Name = "lbANum";
            this.lbANum.Size = new System.Drawing.Size(25, 20);
            this.lbANum.TabIndex = 0;
            this.lbANum.Text = "33";
            // 
            // keyText
            // 
            this.keyText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyText.Location = new System.Drawing.Point(530, 158);
            this.keyText.Multiline = true;
            this.keyText.Name = "keyText";
            this.keyText.ReadOnly = true;
            this.keyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyText.Size = new System.Drawing.Size(282, 140);
            this.keyText.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(534, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Расчет размера ключа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(574, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Рамер ключа:";
            // 
            // lbKNum
            // 
            this.lbKNum.AutoSize = true;
            this.lbKNum.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKNum.Location = new System.Drawing.Point(706, 105);
            this.lbKNum.Name = "lbKNum";
            this.lbKNum.Size = new System.Drawing.Size(0, 23);
            this.lbKNum.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(598, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Lc:";
            // 
            // inpLc
            // 
            this.inpLc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inpLc.Location = new System.Drawing.Point(634, 70);
            this.inpLc.Name = "inpLc";
            this.inpLc.Size = new System.Drawing.Size(66, 29);
            this.inpLc.TabIndex = 9;
            this.inpLc.Text = "0,0529";
            this.inpLc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(203, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(266, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rBAutoC);
            this.panel1.Controls.Add(this.rBAntiC);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(530, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 78);
            this.panel1.TabIndex = 12;
            // 
            // rBAutoC
            // 
            this.rBAutoC.AutoSize = true;
            this.rBAutoC.Checked = true;
            this.rBAutoC.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBAutoC.Location = new System.Drawing.Point(8, 49);
            this.rBAutoC.Name = "rBAutoC";
            this.rBAutoC.Size = new System.Drawing.Size(216, 23);
            this.rBAutoC.TabIndex = 1;
            this.rBAutoC.TabStop = true;
            this.rBAutoC.Text = "Автокорреляционный метод";
            this.rBAutoC.UseVisualStyleBackColor = true;
            this.rBAutoC.CheckedChanged += new System.EventHandler(this.RBAutoC_CheckedChanged);
            // 
            // rBAntiC
            // 
            this.rBAntiC.AutoSize = true;
            this.rBAntiC.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rBAntiC.Location = new System.Drawing.Point(8, 25);
            this.rBAntiC.Name = "rBAntiC";
            this.rBAntiC.Size = new System.Drawing.Size(209, 23);
            this.rBAntiC.TabIndex = 0;
            this.rBAntiC.TabStop = true;
            this.rBAntiC.Text = "Метод каждой n-ной буквы";
            this.rBAntiC.UseVisualStyleBackColor = true;
            this.rBAntiC.CheckedChanged += new System.EventHandler(this.RBAntiC_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(2, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Для индексных совпадений использовать:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(673, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Хочу больше функционала!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(521, 436);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inpLc);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.rB2);
            this.Controls.Add(this.rB1);
            this.Controls.Add(this.inpAlp);
            this.Controls.Add(this.inpKey);
            this.Controls.Add(this.output);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbANum);
            this.Controls.Add(this.lbRNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbKNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Криптоанализ шифра Виженера";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox inpKey;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRNum;
        private System.Windows.Forms.TextBox inpAlp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbANum;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbKNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inpLc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBAutoC;
        private System.Windows.Forms.RadioButton rBAntiC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
    }
}

