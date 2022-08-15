using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        double a = 0;
        double b = 0;
        double c = 0;
        Calculator calc;
        public MainPage()
        {
            InitializeComponent();
        }
        public void input()
        {
            a = Convert.ToDouble(x1.Text);
            b = Convert.ToDouble(x2.Text);
            c = Convert.ToDouble(x3.Text);
            calc = new Calculator(a, b, c);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                input();
                result.Text = calc?.Add().ToString();
            }
            catch
            {
                throw new Exception();
            }
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            try
            {
                input();
                result.Text = calc?.Sub().ToString();
            }
            catch
            {
                throw new Exception();
            }
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            try
            {
                input();
                result.Text = calc?.Mult().ToString();
            }
            catch
            {
                throw new Exception();
            }
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            try
            {
                input();
                result.Text = calc?.Div().ToString();
            }
            catch
            {
                throw new Exception();
            }
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            try
            {
                input();
                result.Text = calc?.Pow().ToString();
            }
            catch
            {
                DisplayAlert("Error", "Error string", "Ok");
            }
        }

        private void Button_Clicked5(object sender, EventArgs e)
        {
            try
            {
                input();
                result.Text = calc?.Ex1().ToString();
            }
            catch
            {
                throw new Exception();
            }
        }

        private void Button_Clicked6(object sender, EventArgs e)
        {
            try
            {
                input();
                result.Text = calc?.Ex2().ToString();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}