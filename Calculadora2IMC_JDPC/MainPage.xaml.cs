using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora2IMC_JDPC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Declarar variable y asignarle valor
            var altura = float.Parse(Altura.Text);
            var peso = float.Parse(Peso.Text);

            //Realizar el calculo
            var imc = peso/(altura*altura);


            //enviar resultado
            IMC.Text = imc.ToString();

            string resultado = "";
            if (imc < 18.5)

            {
                resultado = "Bajo peso";
            }
            else if (imc >= 18.5 && imc< 24.4)

            {
                resultado = "Peso normal";
            }
            else if (imc > 24.9 && imc<= 29.9)

            {
                resultado = "Sobrepeso";
            }
            else if (imc>29.9)
            {
                resultado = "Tienes obesidad, deja la coca";
            }

            DisplayAlert("Resultado ", resultado, "Quitar");
        }
    }
}
