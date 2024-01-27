namespace SortAlgorithmsCSharp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ArrayLbl = new System.Windows.Forms.Label();
            this.FillBtn = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSortBtn = new System.Windows.Forms.Button();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.CompareCountLbl = new System.Windows.Forms.Label();
            this.SwopCountLbl = new System.Windows.Forms.Label();
            this.ShakerSortBtn = new System.Windows.Forms.Button();
            this.InsertionSortBtn = new System.Windows.Forms.Button();
            this.ShellSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddLbl);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 98);
            this.panel1.TabIndex = 0;
            // 
            // AddLbl
            // 
            this.AddLbl.AutoSize = true;
            this.AddLbl.Location = new System.Drawing.Point(8, 9);
            this.AddLbl.Name = "AddLbl";
            this.AddLbl.Size = new System.Drawing.Size(133, 20);
            this.AddLbl.TabIndex = 2;
            this.AddLbl.Text = "Добавить число";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(354, 9);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(104, 82);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(12, 37);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(335, 26);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ArrayLbl);
            this.panel2.Controls.Add(this.FillBtn);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 98);
            this.panel2.TabIndex = 3;
            // 
            // ArrayLbl
            // 
            this.ArrayLbl.AutoSize = true;
            this.ArrayLbl.Location = new System.Drawing.Point(8, 9);
            this.ArrayLbl.Name = "ArrayLbl";
            this.ArrayLbl.Size = new System.Drawing.Size(316, 20);
            this.ArrayLbl.TabIndex = 2;
            this.ArrayLbl.Text = "Заполнить массив случайными числами";
            // 
            // FillBtn
            // 
            this.FillBtn.Location = new System.Drawing.Point(353, 9);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(104, 77);
            this.FillBtn.TabIndex = 1;
            this.FillBtn.Text = "Заполнить";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(12, 37);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(335, 26);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(467, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(656, 202);
            this.panel3.TabIndex = 4;
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.Location = new System.Drawing.Point(12, 220);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(129, 42);
            this.BubbleSortBtn.TabIndex = 5;
            this.BubbleSortBtn.Text = "Bubble Sort";
            this.BubbleSortBtn.UseVisualStyleBackColor = true;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(12, 271);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(62, 20);
            this.TimeLbl.TabIndex = 6;
            this.TimeLbl.Text = "Время:";
            // 
            // CompareCountLbl
            // 
            this.CompareCountLbl.AutoSize = true;
            this.CompareCountLbl.Location = new System.Drawing.Point(12, 291);
            this.CompareCountLbl.Name = "CompareCountLbl";
            this.CompareCountLbl.Size = new System.Drawing.Size(153, 20);
            this.CompareCountLbl.TabIndex = 7;
            this.CompareCountLbl.Text = "Кол-во сравнений: ";
            // 
            // SwopCountLbl
            // 
            this.SwopCountLbl.AutoSize = true;
            this.SwopCountLbl.Location = new System.Drawing.Point(12, 311);
            this.SwopCountLbl.Name = "SwopCountLbl";
            this.SwopCountLbl.Size = new System.Drawing.Size(134, 20);
            this.SwopCountLbl.TabIndex = 8;
            this.SwopCountLbl.Text = "Кол-во обменов:";
            // 
            // ShakerSortBtn
            // 
            this.ShakerSortBtn.Location = new System.Drawing.Point(147, 220);
            this.ShakerSortBtn.Name = "ShakerSortBtn";
            this.ShakerSortBtn.Size = new System.Drawing.Size(129, 42);
            this.ShakerSortBtn.TabIndex = 9;
            this.ShakerSortBtn.Text = "Shaker Sort";
            this.ShakerSortBtn.UseVisualStyleBackColor = true;
            this.ShakerSortBtn.Click += new System.EventHandler(this.ShakerSortBtn_Click);
            // 
            // InsertionSortBtn
            // 
            this.InsertionSortBtn.Location = new System.Drawing.Point(282, 220);
            this.InsertionSortBtn.Name = "InsertionSortBtn";
            this.InsertionSortBtn.Size = new System.Drawing.Size(129, 42);
            this.InsertionSortBtn.TabIndex = 10;
            this.InsertionSortBtn.Text = "Insertion Sort";
            this.InsertionSortBtn.UseVisualStyleBackColor = true;
            this.InsertionSortBtn.Click += new System.EventHandler(this.InsertionSortBtn_Click);
            // 
            // ShellSortBtn
            // 
            this.ShellSortBtn.Location = new System.Drawing.Point(417, 220);
            this.ShellSortBtn.Name = "ShellSortBtn";
            this.ShellSortBtn.Size = new System.Drawing.Size(129, 42);
            this.ShellSortBtn.TabIndex = 11;
            this.ShellSortBtn.Text = "Shell Sort";
            this.ShellSortBtn.UseVisualStyleBackColor = true;
            this.ShellSortBtn.Click += new System.EventHandler(this.ShellSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 652);
            this.Controls.Add(this.ShellSortBtn);
            this.Controls.Add(this.InsertionSortBtn);
            this.Controls.Add(this.ShakerSortBtn);
            this.Controls.Add(this.SwopCountLbl);
            this.Controls.Add(this.CompareCountLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.BubbleSortBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Label AddLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ArrayLbl;
        private System.Windows.Forms.Button FillBtn;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSortBtn;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label CompareCountLbl;
        private System.Windows.Forms.Label SwopCountLbl;
        private System.Windows.Forms.Button ShakerSortBtn;
        private System.Windows.Forms.Button InsertionSortBtn;
        private System.Windows.Forms.Button ShellSortBtn;
    }
}

