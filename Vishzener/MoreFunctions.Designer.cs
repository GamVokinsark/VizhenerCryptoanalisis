namespace Vishzener
{
    partial class MoreFunctions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.outFreq = new System.Windows.Forms.TextBox();
            this.seekKeyBut = new System.Windows.Forms.Button();
            this.outTextGroups = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.outMethod1 = new System.Windows.Forms.TextBox();
            this.outMethod2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.decryptBut = new System.Windows.Forms.Button();
            this.outKeySize1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.outKeySize2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.outKeyVariants = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.clearBut = new System.Windows.Forms.Button();
            this.outKey = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входной текст";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(12, 28);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input.Size = new System.Drawing.Size(468, 114);
            this.input.TabIndex = 1;
            // 
            // outFreq
            // 
            this.outFreq.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outFreq.Location = new System.Drawing.Point(12, 360);
            this.outFreq.Multiline = true;
            this.outFreq.Name = "outFreq";
            this.outFreq.ReadOnly = true;
            this.outFreq.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outFreq.Size = new System.Drawing.Size(960, 190);
            this.outFreq.TabIndex = 1;
            this.outFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seekKeyBut
            // 
            this.seekKeyBut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seekKeyBut.Location = new System.Drawing.Point(1014, 404);
            this.seekKeyBut.Name = "seekKeyBut";
            this.seekKeyBut.Size = new System.Drawing.Size(121, 34);
            this.seekKeyBut.TabIndex = 3;
            this.seekKeyBut.Text = "Найти ключ";
            this.seekKeyBut.UseVisualStyleBackColor = true;
            this.seekKeyBut.Click += new System.EventHandler(this.SeekKeyBut_Click);
            // 
            // outTextGroups
            // 
            this.outTextGroups.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outTextGroups.Location = new System.Drawing.Point(504, 176);
            this.outTextGroups.Multiline = true;
            this.outTextGroups.Name = "outTextGroups";
            this.outTextGroups.ReadOnly = true;
            this.outTextGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outTextGroups.Size = new System.Drawing.Size(468, 148);
            this.outTextGroups.TabIndex = 1;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(504, 28);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(468, 114);
            this.output.TabIndex = 1;
            // 
            // outMethod1
            // 
            this.outMethod1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outMethod1.Location = new System.Drawing.Point(12, 176);
            this.outMethod1.Multiline = true;
            this.outMethod1.Name = "outMethod1";
            this.outMethod1.ReadOnly = true;
            this.outMethod1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outMethod1.Size = new System.Drawing.Size(229, 114);
            this.outMethod1.TabIndex = 1;
            // 
            // outMethod2
            // 
            this.outMethod2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outMethod2.Location = new System.Drawing.Point(251, 176);
            this.outMethod2.Multiline = true;
            this.outMethod2.Name = "outMethod2";
            this.outMethod2.ReadOnly = true;
            this.outMethod2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outMethod2.Size = new System.Drawing.Size(229, 114);
            this.outMethod2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(500, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Расшифрованый текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Метод каждой n-ной буквы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(251, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Автокорреляционный метод";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(500, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Разбитый на группы текст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(452, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Частоты";
            // 
            // decryptBut
            // 
            this.decryptBut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryptBut.Location = new System.Drawing.Point(1014, 450);
            this.decryptBut.Name = "decryptBut";
            this.decryptBut.Size = new System.Drawing.Size(148, 34);
            this.decryptBut.TabIndex = 3;
            this.decryptBut.Text = "Расшифровать";
            this.decryptBut.UseVisualStyleBackColor = true;
            this.decryptBut.Click += new System.EventHandler(this.DecryptBut_Click);
            // 
            // outKeySize1
            // 
            this.outKeySize1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outKeySize1.Location = new System.Drawing.Point(150, 298);
            this.outKeySize1.Name = "outKeySize1";
            this.outKeySize1.ReadOnly = true;
            this.outKeySize1.Size = new System.Drawing.Size(89, 29);
            this.outKeySize1.TabIndex = 4;
            this.outKeySize1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Размер ключа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(251, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Размер ключа";
            // 
            // outKeySize2
            // 
            this.outKeySize2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outKeySize2.Location = new System.Drawing.Point(391, 298);
            this.outKeySize2.Name = "outKeySize2";
            this.outKeySize2.ReadOnly = true;
            this.outKeySize2.Size = new System.Drawing.Size(89, 29);
            this.outKeySize2.TabIndex = 4;
            this.outKeySize2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1010, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ключ";
            // 
            // outKeyVariants
            // 
            this.outKeyVariants.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outKeyVariants.Location = new System.Drawing.Point(992, 28);
            this.outKeyVariants.Multiline = true;
            this.outKeyVariants.Name = "outKeyVariants";
            this.outKeyVariants.ReadOnly = true;
            this.outKeyVariants.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outKeyVariants.Size = new System.Drawing.Size(190, 296);
            this.outKeyVariants.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(988, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Возможные ключи";
            // 
            // clearBut
            // 
            this.clearBut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBut.Location = new System.Drawing.Point(1014, 518);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(132, 32);
            this.clearBut.TabIndex = 5;
            this.clearBut.Text = "Очистить все";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // outKey
            // 
            this.outKey.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outKey.FormattingEnabled = true;
            this.outKey.Location = new System.Drawing.Point(1014, 360);
            this.outKey.Name = "outKey";
            this.outKey.Size = new System.Drawing.Size(121, 29);
            this.outKey.TabIndex = 6;
            // 
            // MoreFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1194, 562);
            this.Controls.Add(this.outKey);
            this.Controls.Add(this.clearBut);
            this.Controls.Add(this.outKeySize2);
            this.Controls.Add(this.outKeySize1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.seekKeyBut);
            this.Controls.Add(this.outFreq);
            this.Controls.Add(this.decryptBut);
            this.Controls.Add(this.outKeyVariants);
            this.Controls.Add(this.output);
            this.Controls.Add(this.outTextGroups);
            this.Controls.Add(this.outMethod2);
            this.Controls.Add(this.outMethod1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MoreFunctions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoreFunctions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox outFreq;
        private System.Windows.Forms.Button seekKeyBut;
        private System.Windows.Forms.TextBox outTextGroups;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox outMethod1;
        private System.Windows.Forms.TextBox outMethod2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button decryptBut;
        private System.Windows.Forms.TextBox outKeySize1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outKeySize2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox outKeyVariants;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button clearBut;
        private System.Windows.Forms.ComboBox outKey;
    }
}