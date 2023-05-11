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


        public MainPage()
        {
            InitializeComponent();
            label = this.FindByName<Label>("text");
        }
        private void HandleClickOnNumber(object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            label.Text += " " + num;
            if (isFirstClick)
            {
                isFirstClick = false;
                number1 = int.Parse(num);
            }
            else
            {
                number2 = int.Parse(num);
            }
        }
        private void HandleClickOnSymbol(object sender, EventArgs e)
        {
            string sign = (sender as Button).Text;
            symbol = sign;
            label.Text += " " + sign;
        }
        private void HandleClickOnEquals(object sender, EventArgs e)
        {

        }
        private void HandleClickOnClear(object sender, EventArgs e)
        {

        }

    }
}
