﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace SharpCalculator
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }


        private void TwoArgumentOperationButtonClick(object sender, EventArgs e)
        {
            var firstArgument = Convert.ToDouble(firstInputField.Text);
            var secondArgument = Convert.ToDouble(secondInputField.Text);
            var calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            var result = calculator.Calculate(firstArgument, secondArgument);
            outputField.Text = result.ToString(CultureInfo.InvariantCulture);
        }
    }
}