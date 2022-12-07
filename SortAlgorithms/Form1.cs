using Algorithm;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        List<SortedItem> items = new List<SortedItem>();


        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(AddTextBox.Text, out int value))
            {
                var item = new SortedItem(value);
                items.Add(new SortedItem(value));
                panel3.Controls.Add(item.ProgressBar);
                panel3.Controls.Add(item.Label);
            }

            AddTextBox.Text = "";
        }

        private void FillButton_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(FillTextBox.Text, out int value))
            {
                var rnd = new Random();

                for (int i = 0; i < value; i++)
                {
                    var item = new SortedItem(rnd.Next());
                    items.Add(item);
                    panel3.Controls.Add(item.ProgressBar);
                    panel3.Controls.Add(item.Label);
                }
            }

            FillTextBox.Text = "";
        }
    }
}
