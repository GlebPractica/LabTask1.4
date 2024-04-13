namespace Task1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FillRandomNumbers = new System.Windows.Forms.Button();
            this.CountElGreaterSeven = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(379, 137);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearItems
            // 
            this.ClearItems.Location = new System.Drawing.Point(280, 231);
            this.ClearItems.Name = "ClearItems";
            this.ClearItems.Size = new System.Drawing.Size(111, 23);
            this.ClearItems.TabIndex = 4;
            this.ClearItems.Text = "Очистить список";
            this.ClearItems.UseVisualStyleBackColor = true;
            this.ClearItems.Click += new System.EventHandler(this.ClearItems_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Линейный односвязанный список";
            // 
            // FillRandomNumbers
            // 
            this.FillRandomNumbers.Location = new System.Drawing.Point(55, 128);
            this.FillRandomNumbers.Name = "FillRandomNumbers";
            this.FillRandomNumbers.Size = new System.Drawing.Size(290, 31);
            this.FillRandomNumbers.TabIndex = 6;
            this.FillRandomNumbers.Text = "Заполнить случайными числами";
            this.FillRandomNumbers.UseVisualStyleBackColor = true;
            this.FillRandomNumbers.Click += new System.EventHandler(this.FillRandomNumbers_Click);
            // 
            // CountElGreaterSeven
            // 
            this.CountElGreaterSeven.Location = new System.Drawing.Point(55, 165);
            this.CountElGreaterSeven.Name = "CountElGreaterSeven";
            this.CountElGreaterSeven.Size = new System.Drawing.Size(290, 31);
            this.CountElGreaterSeven.TabIndex = 7;
            this.CountElGreaterSeven.Text = "Количество элементов больше 7";
            this.CountElGreaterSeven.UseVisualStyleBackColor = true;
            this.CountElGreaterSeven.Click += new System.EventHandler(this.CountElGreaterSeven_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 416);
            this.Controls.Add(this.CountElGreaterSeven);
            this.Controls.Add(this.FillRandomNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClearItems);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FillRandomNumbers;
        private System.Windows.Forms.Button CountElGreaterSeven;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

