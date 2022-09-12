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


        private void Boton1_Clicked(object sender, EventArgs e)
        {
            string user = (Input.Text != "") ? Input.Text : "Usuario";

            DisplayAlert("Hola Mundo", $"Bienvenido {user}", "Ok");
        }

        private void Boton2_Clicked(object sender, EventArgs e)
        {
            num++;
            if (num % 2 == 0)
            {
                Boton2.BackgroundColor = Color.Red;
                Boton2.TextColor = Color.White;
            }
            else
            {
                Boton2.BackgroundColor = Color.Black;
                Boton2.TextColor = Color.Aqua;
            }
        }
        int num;
    }
}