namespace Lab2TechCloud
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
            this.Dictionar = new System.Windows.Forms.Button();
            this.CloudBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(13, 13);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(244, 23);
            this.Load.TabIndex = 0;
            this.Load.Text = "Загрузить текст для анализа";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Dictionar
            // 
            this.Dictionar.Location = new System.Drawing.Point(13, 42);
            this.Dictionar.Name = "Dictionar";
            this.Dictionar.Size = new System.Drawing.Size(244, 23);
            this.Dictionar.TabIndex = 3;
            this.Dictionar.Text = "Загрузить словарь";
            this.Dictionar.UseVisualStyleBackColor = true;
            this.Dictionar.Click += new System.EventHandler(this.Dictionar_Click);
            // 
            // CloudBut
            // 
            this.CloudBut.Location = new System.Drawing.Point(12, 71);
            this.CloudBut.Name = "CloudBut";
            this.CloudBut.Size = new System.Drawing.Size(245, 23);
            this.CloudBut.TabIndex = 4;
            this.CloudBut.Text = "Найти облако тегов";
            this.CloudBut.UseVisualStyleBackColor = true;
            this.CloudBut.Click += new System.EventHandler(this.CloudBut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 253);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 365);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CloudBut);
            this.Controls.Add(this.Dictionar);
            this.Controls.Add(this.Load);
            this.Name = "Form1";
            this.Text = "Облако тегов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Dictionar;
        private System.Windows.Forms.Button CloudBut;
        private System.Windows.Forms.TextBox textBox1;
    }
}

