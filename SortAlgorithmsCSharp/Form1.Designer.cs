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
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.HeapSortBtn = new System.Windows.Forms.Button();
            this.GnomeSortBtn = new System.Windows.Forms.Button();
            this.TreeSortBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.LsdRadixSortBtn = new System.Windows.Forms.Button();
            this.MsdRadixSortBtn = new System.Windows.Forms.Button();
            this.MergeSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddLbl);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(5, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 50);
            this.panel1.TabIndex = 0;
            // 
            // AddLbl
            // 
            this.AddLbl.AutoSize = true;
            this.AddLbl.Location = new System.Drawing.Point(1, 9);
            this.AddLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddLbl.Name = "AddLbl";
            this.AddLbl.Size = new System.Drawing.Size(151, 13);
            this.AddLbl.TabIndex = 2;
            this.AddLbl.Text = "Добавить конкретное число";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(159, 9);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(70, 35);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(4, 24);
            this.AddTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(148, 20);
            this.AddTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FillBtn);
            this.panel2.Controls.Add(this.ArrayLbl);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Location = new System.Drawing.Point(4, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 50);
            this.panel2.TabIndex = 3;
            // 
            // ArrayLbl
            // 
            this.ArrayLbl.AutoSize = true;
            this.ArrayLbl.Location = new System.Drawing.Point(2, 5);
            this.ArrayLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArrayLbl.Name = "ArrayLbl";
            this.ArrayLbl.Size = new System.Drawing.Size(146, 13);
            this.ArrayLbl.TabIndex = 2;
            this.ArrayLbl.Text = "Добавить случайные числа";
            // 
            // FillBtn
            // 
            this.FillBtn.Location = new System.Drawing.Point(160, 5);
            this.FillBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(70, 35);
            this.FillBtn.TabIndex = 1;
            this.FillBtn.Text = "Заполнить";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(5, 20);
            this.FillTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(148, 20);
            this.FillTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(11, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 131);
            this.panel3.TabIndex = 4;
            // 
            // BubbleSortBtn
            // 
            this.BubbleSortBtn.Location = new System.Drawing.Point(5, 27);
            this.BubbleSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BubbleSortBtn.Name = "BubbleSortBtn";
            this.BubbleSortBtn.Size = new System.Drawing.Size(80, 35);
            this.BubbleSortBtn.TabIndex = 5;
            this.BubbleSortBtn.Text = "Bubble Sort";
            this.BubbleSortBtn.UseVisualStyleBackColor = true;
            this.BubbleSortBtn.Click += new System.EventHandler(this.BubbleSortBtn_Click);
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(6, 16);
            this.TimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(108, 13);
            this.TimeLbl.TabIndex = 6;
            this.TimeLbl.Text = "Время выполнения:";
            // 
            // CompareCountLbl
            // 
            this.CompareCountLbl.AutoSize = true;
            this.CompareCountLbl.Location = new System.Drawing.Point(6, 29);
            this.CompareCountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompareCountLbl.Name = "CompareCountLbl";
            this.CompareCountLbl.Size = new System.Drawing.Size(126, 13);
            this.CompareCountLbl.TabIndex = 7;
            this.CompareCountLbl.Text = "Количество сравнений:";
            // 
            // SwopCountLbl
            // 
            this.SwopCountLbl.AutoSize = true;
            this.SwopCountLbl.Location = new System.Drawing.Point(6, 42);
            this.SwopCountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SwopCountLbl.Name = "SwopCountLbl";
            this.SwopCountLbl.Size = new System.Drawing.Size(116, 13);
            this.SwopCountLbl.TabIndex = 8;
            this.SwopCountLbl.Text = "Количество обменов:";
            // 
            // ShakerSortBtn
            // 
            this.ShakerSortBtn.Location = new System.Drawing.Point(89, 27);
            this.ShakerSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShakerSortBtn.Name = "ShakerSortBtn";
            this.ShakerSortBtn.Size = new System.Drawing.Size(80, 35);
            this.ShakerSortBtn.TabIndex = 9;
            this.ShakerSortBtn.Text = "Shaker Sort";
            this.ShakerSortBtn.UseVisualStyleBackColor = true;
            this.ShakerSortBtn.Click += new System.EventHandler(this.ShakerSortBtn_Click);
            // 
            // InsertionSortBtn
            // 
            this.InsertionSortBtn.Location = new System.Drawing.Point(5, 66);
            this.InsertionSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InsertionSortBtn.Name = "InsertionSortBtn";
            this.InsertionSortBtn.Size = new System.Drawing.Size(80, 35);
            this.InsertionSortBtn.TabIndex = 10;
            this.InsertionSortBtn.Text = "Insertion Sort";
            this.InsertionSortBtn.UseVisualStyleBackColor = true;
            this.InsertionSortBtn.Click += new System.EventHandler(this.InsertionSortBtn_Click);
            // 
            // ShellSortBtn
            // 
            this.ShellSortBtn.Location = new System.Drawing.Point(173, 27);
            this.ShellSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ShellSortBtn.Name = "ShellSortBtn";
            this.ShellSortBtn.Size = new System.Drawing.Size(80, 35);
            this.ShellSortBtn.TabIndex = 11;
            this.ShellSortBtn.Text = "Shell Sort";
            this.ShellSortBtn.UseVisualStyleBackColor = true;
            this.ShellSortBtn.Click += new System.EventHandler(this.ShellSortBtn_Click);
            // 
            // SelectionSortBtn
            // 
            this.SelectionSortBtn.Location = new System.Drawing.Point(425, 27);
            this.SelectionSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SelectionSortBtn.Name = "SelectionSortBtn";
            this.SelectionSortBtn.Size = new System.Drawing.Size(80, 35);
            this.SelectionSortBtn.TabIndex = 12;
            this.SelectionSortBtn.Text = "Selection Sort";
            this.SelectionSortBtn.UseVisualStyleBackColor = true;
            this.SelectionSortBtn.Click += new System.EventHandler(this.SelectionSortBtn_Click);
            // 
            // HeapSortBtn
            // 
            this.HeapSortBtn.Location = new System.Drawing.Point(341, 27);
            this.HeapSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HeapSortBtn.Name = "HeapSortBtn";
            this.HeapSortBtn.Size = new System.Drawing.Size(80, 35);
            this.HeapSortBtn.TabIndex = 13;
            this.HeapSortBtn.Text = "Heap Sort";
            this.HeapSortBtn.UseVisualStyleBackColor = true;
            this.HeapSortBtn.Click += new System.EventHandler(this.HeapSortBtn_Click);
            // 
            // GnomeSortBtn
            // 
            this.GnomeSortBtn.Location = new System.Drawing.Point(89, 66);
            this.GnomeSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GnomeSortBtn.Name = "GnomeSortBtn";
            this.GnomeSortBtn.Size = new System.Drawing.Size(80, 35);
            this.GnomeSortBtn.TabIndex = 14;
            this.GnomeSortBtn.Text = "Gnome Sort";
            this.GnomeSortBtn.UseVisualStyleBackColor = true;
            this.GnomeSortBtn.Click += new System.EventHandler(this.GnomeSortBtn_Click);
            // 
            // TreeSortBtn
            // 
            this.TreeSortBtn.Location = new System.Drawing.Point(257, 27);
            this.TreeSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TreeSortBtn.Name = "TreeSortBtn";
            this.TreeSortBtn.Size = new System.Drawing.Size(80, 35);
            this.TreeSortBtn.TabIndex = 15;
            this.TreeSortBtn.Text = "Tree Sort";
            this.TreeSortBtn.UseVisualStyleBackColor = true;
            this.TreeSortBtn.Click += new System.EventHandler(this.TreeSortBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.QuickSortBtn);
            this.groupBox3.Controls.Add(this.MergeSortBtn);
            this.groupBox3.Controls.Add(this.MsdRadixSortBtn);
            this.groupBox3.Controls.Add(this.LsdRadixSortBtn);
            this.groupBox3.Controls.Add(this.ShellSortBtn);
            this.groupBox3.Controls.Add(this.BubbleSortBtn);
            this.groupBox3.Controls.Add(this.HeapSortBtn);
            this.groupBox3.Controls.Add(this.TreeSortBtn);
            this.groupBox3.Controls.Add(this.ShakerSortBtn);
            this.groupBox3.Controls.Add(this.InsertionSortBtn);
            this.groupBox3.Controls.Add(this.SelectionSortBtn);
            this.groupBox3.Controls.Add(this.GnomeSortBtn);
            this.groupBox3.Location = new System.Drawing.Point(262, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 112);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сортировки";
            // 
            // QuickSortBtn
            // 
            this.QuickSortBtn.Location = new System.Drawing.Point(425, 66);
            this.QuickSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.QuickSortBtn.Name = "QuickSortBtn";
            this.QuickSortBtn.Size = new System.Drawing.Size(80, 35);
            this.QuickSortBtn.TabIndex = 19;
            this.QuickSortBtn.Text = "Quick Sort";
            this.QuickSortBtn.UseVisualStyleBackColor = true;
            this.QuickSortBtn.Click += new System.EventHandler(this.QuickSortBtn_Click);
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 180);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции с числами";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeLbl);
            this.groupBox2.Controls.Add(this.CompareCountLbl);
            this.groupBox2.Controls.Add(this.SwopCountLbl);
            this.groupBox2.Location = new System.Drawing.Point(262, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 62);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ClearBtn);
            this.panel4.Location = new System.Drawing.Point(5, 126);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 50);
            this.panel4.TabIndex = 4;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(4, 8);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(225, 35);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // LsdRadixSortBtn
            // 
            this.LsdRadixSortBtn.Location = new System.Drawing.Point(173, 66);
            this.LsdRadixSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LsdRadixSortBtn.Name = "LsdRadixSortBtn";
            this.LsdRadixSortBtn.Size = new System.Drawing.Size(80, 35);
            this.LsdRadixSortBtn.TabIndex = 16;
            this.LsdRadixSortBtn.Text = "LSD Radix Sort";
            this.LsdRadixSortBtn.UseVisualStyleBackColor = true;
            this.LsdRadixSortBtn.Click += new System.EventHandler(this.LsdRadixSortBtn_Click);
            // 
            // MsdRadixSortBtn
            // 
            this.MsdRadixSortBtn.Location = new System.Drawing.Point(257, 66);
            this.MsdRadixSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MsdRadixSortBtn.Name = "MsdRadixSortBtn";
            this.MsdRadixSortBtn.Size = new System.Drawing.Size(80, 35);
            this.MsdRadixSortBtn.TabIndex = 17;
            this.MsdRadixSortBtn.Text = "MSD Radix Sort";
            this.MsdRadixSortBtn.UseVisualStyleBackColor = true;
            this.MsdRadixSortBtn.Click += new System.EventHandler(this.MsdRadixSortBtn_Click);
            // 
            // MergeSortBtn
            // 
            this.MergeSortBtn.Location = new System.Drawing.Point(341, 66);
            this.MergeSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MergeSortBtn.Name = "MergeSortBtn";
            this.MergeSortBtn.Size = new System.Drawing.Size(80, 35);
            this.MergeSortBtn.TabIndex = 18;
            this.MergeSortBtn.Text = "Merge Sort";
            this.MergeSortBtn.UseVisualStyleBackColor = true;
            this.MergeSortBtn.Click += new System.EventHandler(this.MergeSortBtn_Click);
            // 
            // QuickSortBtn
            // 
            this.QuickSortBtn.Location = new System.Drawing.Point(425, 66);
            this.QuickSortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.QuickSortBtn.Name = "QuickSortBtn";
            this.QuickSortBtn.Size = new System.Drawing.Size(80, 35);
            this.QuickSortBtn.TabIndex = 19;
            this.QuickSortBtn.Text = "Quick Sort";
            this.QuickSortBtn.UseVisualStyleBackColor = true;
            this.QuickSortBtn.Click += new System.EventHandler(this.QuickSortBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Визуализация алгоритмов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button SelectionSortBtn;
        private System.Windows.Forms.Button HeapSortBtn;
        private System.Windows.Forms.Button GnomeSortBtn;
        private System.Windows.Forms.Button TreeSortBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button QuickSortBtn;
        private System.Windows.Forms.Button MergeSortBtn;
        private System.Windows.Forms.Button MsdRadixSortBtn;
        private System.Windows.Forms.Button LsdRadixSortBtn;
    }
}

