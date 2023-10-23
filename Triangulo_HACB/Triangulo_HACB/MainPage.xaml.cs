using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Triangulo_HACB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender,EventArgs e)
        {
            //declara vaariable y asinacion valor
            var bas3 = double.Parse(Base.Text);
            var altura = double.Parse(Altura.Text);
            var lado1 = double.Parse(PrimerLado.Text);
            var lado2 = double.Parse(SegundoLado.Text);
            //realizar el calculo
            var area = (bas3 * altura) / 2;
            //Enviar resultado
            Area.Text = area.ToString();

            string resultado = "";
            if (lado1 + lado2 < bas3 || lado1 + bas3 < lado2 || lado2 + bas3 < lado1)
            {
                resultado = "No es un triangulo";
            }
            else
            {

                if (lado1 == bas3 && lado2 == bas3)
                {
                    resultado = "Triangulo Equilátero";
                    ImgEquilatero.IsVisible = true;
                    Imgisosceles.IsVisible = false;
                    ImgEscaleno.IsVisible = false;

                }
                else if (lado1 == bas3 && lado2 != bas3)
                {
                    resultado = "Triangulo Isósceles";
                    Imgisosceles.IsVisible = true;
                    ImgEquilatero.IsVisible = false;
                    ImgEscaleno.IsVisible = false;
                }
                else if (lado1 != bas3 && lado2 != bas3)
                {
                    resultado = "Triangulo Escaleno";
                    ImgEscaleno.IsVisible = true;
                    ImgEquilatero.IsVisible = false;
                    Imgisosceles.IsVisible = false;
                }
            }
            DisplayAlert("Resultado:", resultado, "Quita");

        }
    }
}
