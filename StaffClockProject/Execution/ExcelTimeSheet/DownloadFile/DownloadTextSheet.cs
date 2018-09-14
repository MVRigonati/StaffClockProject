using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using String = System.String;

namespace StaffClockProject.DownloadFile {

    class DownloadTextSheet {

        private String Url { get; set; }
        private String User { get; set; }
        private String Password { get; set; }

        public DownloadTextSheet(String url, String usr, String password) {
            this.Url = url;
            this.User = usr;
            this.Password = password;
        }

        public void Download(String dataIni, String dataFim, int tempoEspera) {
            
            // http://chromedriver.storage.googleapis.com/index.html?path=2.41/
            IWebDriver driver = null;
            try {

                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(this.Url);

                // Login
                driver.FindElement(By.Id("lblLogin"))
                    .SendKeys(this.User);

                // Senha
                driver.FindElement(By.Id("lblPass"))
                    .SendKeys(this.Password);

                // É necessário o clique no botão entrar, submit não funciona
                driver.FindElement(By.LinkText("Entrar")).Click();

                // Entrando no menu de eventos
                ClickOn(driver, "divMenuEvents");

                // Alterando forma de filtro
                ClickOn(driver, "menuItem2");

                // Inserindo filtros
                IWebElement inputDataIni = driver.FindElement(By.Id("lblDataI"));
                inputDataIni.Clear();
                inputDataIni.SendKeys(dataIni);

                IWebElement inputDataFim = driver.FindElement(By.Id("lblDataF"));
                inputDataFim.Clear();
                inputDataFim.SendKeys(dataFim);

                // Realizando download
                driver.FindElement(By.LinkText("Baixar Dados")).Click();
                Thread.Sleep(tempoEspera);
                driver.Close();

            } catch (Exception) {
                driver.Close();
            }

        }

        /// <summary>
        /// Este método tem a função de fazer uma tentativa de click a cada
        /// um segundo.
        /// Foi necessário este tratamento pois o site do ponto eletrônico da
        /// B.C.F. não envia submits, ele trabalha com funções JavaScript e
        /// eu não consegui saber quando que a função já carregou a próxima
        /// página.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="id"></param>
        private static void ClickOn(IWebDriver driver, string id) {
            try {
                driver.FindElement(By.Id(id)).Click();
            } catch (NoSuchElementException) {
                Thread.Sleep(1000);
                ClickOn(driver, id);
            }
        }

    }

}
