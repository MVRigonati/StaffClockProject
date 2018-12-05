using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;

namespace StaffClockProject.DownloadFile {

    class DownloadTextSheet {

        private readonly String url;
        private readonly String user;
        private readonly String password;
        private readonly String downloadPath;

        public DownloadTextSheet(String url, String user, String password, String downloadPath) {

            if (!url.StartsWith("http")) {
                url = "http://" + url;
            }
            this.url = url;

            this.user = user;
            this.password = password;
            this.downloadPath = downloadPath;

        }

        public void Download(String dataIni, String dataFim, int tempoEspera) {

            IWebDriver driver = null;
            try {

                // http://chromedriver.storage.googleapis.com/index.html?path=2.41/
                driver = new ChromeDriver(@"C:\Chrome\driver", DownloadPathConfigurations());
                driver.Navigate().GoToUrl(this.url);

                // Login
                driver.FindElement(By.Id("lblLogin"))
                    .SendKeys(this.user);

                // Senha
                driver.FindElement(By.Id("lblPass"))
                    .SendKeys(this.password);

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

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                driver.Close();
            }

        }

        private ChromeOptions DownloadPathConfigurations() {

            // Muda o caminho onde o arquivo será baixado
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", this.downloadPath);
            chromeOptions.AddUserProfilePreference("intl.accept_languages", "nl");
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            return chromeOptions;

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
        private static void ClickOn(IWebDriver driver, String id) {
            try {
                driver.FindElement(By.Id(id)).Click();
            } catch (NoSuchElementException) {
                Thread.Sleep(1000);
                ClickOn(driver, id);
            }
        }

    }

}