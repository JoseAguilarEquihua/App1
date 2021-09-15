using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {

        int _count;
        string _message;
        Button button1;
        public MainPage()
        {
            InitializeComponent();
            _count = 0;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (button1 == null)
                button1 = ((Button)sender);

            _count++;
            _message = "You clicked me {0} times";
            button1.Text = string.Format(_message, _count);
            
            
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            _message = "Click me";
            _count = 0;
            if(button1 != null)
            {
                button1.Text = _message;
            }
        }
    }
}
