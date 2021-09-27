using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace counter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private int contador = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {

            contador++;
            res.Text = contador.ToString();
    }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            contador--;
            res.Text = contador.ToString();
            if (contador < 0)
            {
                contador = 0;
                res.Text = contador.ToString();

            }
        }
        private void ButtonReset(object sender, EventArgs e)
        {
            contador = 0;
            res.Text = contador.ToString();
        }
    }
