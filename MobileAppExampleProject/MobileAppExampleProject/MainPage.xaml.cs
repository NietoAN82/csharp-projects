using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace MobileAppExampleProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        private async Task PulsateButton(Xamarin.Forms.Button myButton)
        {
            uint duration = 1000; // pulse duration in milliseconds
            uint halfDuration = duration / 2;

            await myButton.ScaleTo(1.2, halfDuration); // increase the button size
            await Task.Delay((int)halfDuration); // wait for half the duration
            await myButton.ScaleTo(1, halfDuration); // decrease the button size
        }
        private async void MyButton_Clicked(object sender, EventArgs e)
        {
            await PulsateButton(myButton);
        }
    }
}
