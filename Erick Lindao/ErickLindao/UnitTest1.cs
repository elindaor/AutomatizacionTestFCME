
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V114.Console;
using OpenQA.Selenium.Support.UI;

namespace ErickLindao
{
    [TestClass]
    public class UnitTest1
    {

        //Se inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"C:\Users\User\Desktop\Proyecto\PruebasUnitarias\ErickLindao\dll\116.0.5845.96");

        //instancia de manera global la URL de la pagina a testear
        public string url = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx";


        [TestMethod]
        public void Login()
        {
            ITakesScreenshot ScreenShotDrive = driver as ITakesScreenshot;

            Screenshot screenshot = ScreenShotDrive.GetScreenshot();

            try
            {
             //set de la pagina a probar
             driver.Navigate().GoToUrl(url);

            //se maximiza el tamaño de ventana
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            //instancia de los campos a traves de find elements
            driver.FindElement(By.Id("LoginUser_UserName"));
            driver.FindElement(By.Id("LoginUser_UserName")).Click();
            driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("Demo");

            driver.FindElement(By.Id("LoginUser_Password"));
            driver.FindElement(By.Id("LoginUser_Password")).Click();
            driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");

            Thread.Sleep(4000);

            //localizar boton de login y hacer click
            driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

            Thread.Sleep(4000);

            driver.FindElement(By.Id("liClientes")).Click();

            Thread.Sleep(3000);

            driver.FindElement(By.Id("MainContent_btnAdd")).Click();
            Thread.Sleep(2000);


            //llenar el formulario

            driver.FindElement(By.Id("MainContent_txtNombreCliente"));
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).Click();
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("Erick Lindao");
            Thread.Sleep(2000);

            var TipoIdent = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
            var selectelement = new SelectElement(TipoIdent);
            selectelement.SelectByValue("05");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_txtIdentificacion"));
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).Click();
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0927238535");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional"));
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).Click();
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("043098298");
            Thread.Sleep(2000);
                
            driver.FindElement(By.Id("MainContent_txtExtension"));
            driver.FindElement(By.Id("MainContent_txtExtension")).Click();
            driver.FindElement(By.Id("MainContent_txtExtension")).SendKeys("4234");
            Thread.Sleep(2000);
                

            driver.FindElement(By.Id("MainContent_txtDireccion"));
            driver.FindElement(By.Id("MainContent_txtDireccion")).Click();
            driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("Guasmo Sur Coop. Pablo Neruda");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("elindaor@gmail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("MainContent_txtCorreosCopiaCliente")).SendKeys("lre_0711@hotmail.com");
            Thread.Sleep(2000);

            IWebElement check1 = driver.FindElement(By.Id("MainContent_cbxEnviarBienvenida"));
            check1.Click();

            driver.FindElement(By.Id("MainContent_txtTelefonoCelular"));
            driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).Click();
            driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).SendKeys("09284715100");
            Thread.Sleep(2000);



                driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();

                Thread.Sleep(5000);
                screenshot = ScreenShotDrive.GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\User\Desktop\Proyecto\PruebasUnitarias\ErickLindao\PrintScreenPruebas\ProcesoOK" + DateTime.Now.Ticks.ToString() + ".png");
            }
            catch (Exception ex)
            {
                screenshot = ScreenShotDrive.GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\User\Desktop\Proyecto\PruebasUnitarias\ErickLindao\PrintScreenPruebas\" + " Error " + ".png");
                Thread.Sleep(3000);
                driver.Close();
            }
        }
    }
}