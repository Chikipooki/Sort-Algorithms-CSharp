﻿using System;
using System.Drawing;
using Label = System.Windows.Forms.Label;

namespace SortAlgorithms
{
    internal class SortedItem : IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; private set; }
        public int Number { get; private set; }
        public int StartNumber { get; private set; }

        public SortedItem(int value, int number)
        {
            Value = value;
            Number = number;
            StartNumber = number;
            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label = new Label();

            var X_locationOfProgBar = number * 20;
            //
            // verticalProgressBar1
            //
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = Color.Blue;
            ProgressBar.Location = new Point(X_locationOfProgBar, 3);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar" + number;
            ProgressBar.Size = new Size(18, 96);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            //
            // ScoreLabel
            //
            Label.AutoSize = true;
            Label.Location = new Point(X_locationOfProgBar, 102);
            Label.Name = "ScoreLabel" + number;
            Label.Size = new Size(19, 13);
            Label.TabIndex = number;
            Label.Text = Value.ToString();
        }

        public void SetPosition(int number)
        {
            Number = number;
            var X_locationOfProgBar = number * 20;
            ProgressBar.Location = new Point(X_locationOfProgBar, 3);
            ProgressBar.Name = "ProgressBar" + number;
            Label.Location = new Point(X_locationOfProgBar, 102);
            Label.Name = "ScoreLabel" + number;
        }

        public void Refresh()
        {
            Number = StartNumber;
            var X_locationOfProgBar = Number * 20;
            ProgressBar.Location = new Point(X_locationOfProgBar, 3);
            ProgressBar.Name = "ProgressBar" + Number;
            Label.Location = new Point(X_locationOfProgBar, 102);
            Label.Name = "ScoreLabel" + Number;
        }

        public void SetColor(Color color)
        {
            ProgressBar.Color = color;
        }

        public int CompareTo(object obj)
        {
            if (obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj is not {nameof(SortedItem)}", nameof(obj));
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}