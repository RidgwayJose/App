using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantillaPage : ContentPage
    {
        public PlantillaPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            num++;
            if (num % 2 == 0)
            {
                Boton1.BackgroundColor = Color.Red;
                Boton1.TextColor = Color.White;
            }
            else
            {
                Boton1.BackgroundColor = Color.Black;
                Boton1.TextColor = Color.Aqua;
            }
        }

        int num = 0;

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string user = (Input.Text != "") ? Input.Text : "Usuario";

            DisplayAlert("Hola Mundo",$"Bienvenido {user}","Ok");
        }
    }
}