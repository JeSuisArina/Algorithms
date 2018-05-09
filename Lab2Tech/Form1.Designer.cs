namespace Lab2Tech
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Load = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Shingles = new System.Windows.Forms.Button();
            this.MultyLoad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Load.Location = new System.Drawing.Point(12, 257);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(300, 23);
            this.Load.TabIndex = 0;
            this.Load.Text = "Выбрать текст";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 200);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Shingles
            // 
            this.Shingles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Shingles.Enabled = false;
            this.Shingles.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Shingles.Location = new System.Drawing.Point(12, 315);
            this.Shingles.Name = "Shingles";
            this.Shingles.Size = new System.Drawing.Size(300, 23);
            this.Shingles.TabIndex = 3;
            this.Shingles.Text = "Проверить на плагиат";
            this.Shingles.UseVisualStyleBackColor = false;
            this.Shingles.Click += new System.EventHandler(this.Shingles_Click);
            // 
            // MultyLoad
            // 
            this.MultyLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MultyLoad.Enabled = false;
            this.MultyLoad.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.MultyLoad.Location = new System.Drawing.Point(12, 286);
            this.MultyLoad.Name = "MultyLoad";
            this.MultyLoad.Size = new System.Drawing.Size(300, 23);
            this.MultyLoad.TabIndex = 6;
            this.MultyLoad.Text = "Загрузить файлы для сравнения";
            this.MultyLoad.UseVisualStyleBackColor = false;
            this.MultyLoad.Click += new System.EventHandler(this.MultyLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(318, 257);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 108);
            this.listBox1.TabIndex = 7;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(318, 25);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(300, 200);
            this.richTextBox4.TabIndex = 8;
            this.richTextBox4.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Текст максимальной схожести ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Результаты проверки на плагиат";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Clear.Location = new System.Drawing.Point(15, 342);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(297, 23);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(633, 375);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MultyLoad);
            this.Controls.Add(this.Shingles);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Load);
            this.Name = "Form1";
            this.Text = "Антиплагиат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Shingles;
        private System.Windows.Forms.Button MultyLoad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Clear;
    }
}

