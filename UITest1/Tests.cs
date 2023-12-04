using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
namespace UITest1
{
    [TestFixture(Platform.Android)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            //Se ejecutara antes de empezar cualquier prueba de UI
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }


        [Test]
        public void Agregar60_170UITest()
        {


            app.EnterText("EntadaA","60");
            app.EnterText("EntadaB", "170");


            app.Tap("Entradas");

           var appResultado= app.Query("Resultado").First(result => result.Text == "12");
            Assert.IsTrue(appResultado !=null, "No muestra el resultado esperado");
        }

    }
}
