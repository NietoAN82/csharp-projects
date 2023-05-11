using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        Label label;
        int number1;
        int number2;
        string symbol;
        bool isFirstClick = true;
        string numberString = "";

        public MainPage()
        {
            InitializeComponent();
            label = this.FindByName<Label>("text");
        }

        private void HandleClickOnNumber(object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            label.Text += " " + num;
            numberString += num;
        }

        private void HandleClickOnSymbol(object sender, EventArgs e)
        {
            string sign = (sender as Button).Text;
            symbol = sign;
            label.Text += " " + sign;
            // parse number1 from the input string
            number1 = int.Parse(numberString);
            // reset numberString for the next input number
            numberString = "";
            isFirstClick = false;
        }

        private void HandleClickOnEquals(object sender, EventArgs e)
        {
            // parse number2 from the input string
            int number2 = int.Parse(numberString);

            int result = 0;
            switch (symbol)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "%":
                    result = number1 % number2;
                    break;
            }
            label.Text += " = " + result.ToString();
            numberString = "";
        }

        private void HandleClickOnClear(object sender, EventArgs e)
        {
            isFirstClick = true;
            numberString = "";
            label.Text = "";
        }
    }

}
