using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ContadorAppMovil
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

        protected void Button_Clicked(object sender, EventArgs e)
        {
            if (button1 == null)
                button1 = ((Button)sender);

            _count++;
            _message = "Me has pulsado {0} veces";
            button1.Text = string.Format(_message, _count);

        }

        protected void Button_Reset(object sender, EventArgs e)
        {
            _message = "Pulsame";
            _count = 0;
            if (button1 != null){
                button1.Text = _message;
            }
        }
    }

    
}
