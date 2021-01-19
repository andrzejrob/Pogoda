using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace Pogoda
{
    public partial class Pogoda : Form
    {
        private const string API = "APPID=63dc1cfd0697338d911b5d85f51358cc";
        private const string OWM = "http://api.openweathermap.org/data/2.5/weather?";
        public Pogoda()
        {
            InitializeComponent();
            setLabelVisibleStatus(false);
        }

        class windowSize
        {
            public const int windowWithoutJsonDataWidht = 888;
            public const int windowWithoutJsonDataLength = 545;
            public const int windowWithJsonDataWidth = 888;
            public const int windowWithJsonDataLength = 802;
        }
        private JsonWeatherReport getJsonData(string url)
        {
            using (WebClient client = new WebClient())
            {
                string receiveJson = client.DownloadString(url);
                JsonWeatherReport weather;
                weather = JsonConvert.DeserializeObject<JsonWeatherReport>(receiveJson);
                UpdateDataRichTxtBox(weather);
                return weather;
            }
        }

        private string makeRequestUrl(string cityID)
        {
            string requestAddr = OWM + "q=" +Cities.SelectedItem.ToString()+",pl&"+ API;
            return requestAddr;
        }

        private void displRitchTxtBox(string txt)
        {
            jsonWeatherRichTxtBox.AppendText(txt + Environment.NewLine);
        }

        private void UpdateDataRichTxtBox(JsonWeatherReport weatherData)
        {
            displRitchTxtBox("Odczytana pogoda:");
            displRitchTxtBox("Współrzędne geograficzne:");
            displRitchTxtBox("Długość geograficzna: " + System.Convert.ToString(weatherData.Coord.Lon) + " ; Szerokość geograficzna: " + System.Convert.ToString(weatherData.Coord.Lat));
            displRitchTxtBox("Nazwa miasta: " + weatherData.Name + " ;");
            displRitchTxtBox("Kraj: " + weatherData.Sys.Country + " ;");
            displRitchTxtBox("Id miasta: " + System.Convert.ToString(weatherData.Id) + " ;");
            displRitchTxtBox("Odczytana temperatura: " + System.Convert.ToString(Math.Truncate((weatherData.Main.Temp - 273) * 100) / 100) + " °C ;");
            displRitchTxtBox("Ciśnienie: " + System.Convert.ToString(weatherData.Main.Pressure) + " hPa ;");
            displRitchTxtBox("Wilgotność: " + System.Convert.ToString(weatherData.Main.Humidity) + " % ;");
            displRitchTxtBox("Temperatura minimalna: " + System.Convert.ToString(Math.Truncate((weatherData.Main.TempMin - 273) * 100) / 100) + " °C ;");
            displRitchTxtBox("Temperatura maksymalna: " + System.Convert.ToString(Math.Truncate((weatherData.Main.TempMax - 273) * 100) / 100) + " °C ;");
            displRitchTxtBox("Prędkość wiatru: " + System.Convert.ToString(weatherData.Wind.Speed) + " m/s ;");
            displRitchTxtBox("Kierunek wiatru: " + System.Convert.ToString(weatherData.Wind.Deg) + " ;");
            displRitchTxtBox("Zachmurzenie: " + System.Convert.ToString(weatherData.Clouds.All) + " % ;");
            displRitchTxtBox("Wschód słońca: " + System.Convert.ToString(conversionFunction.UnixTimeStampToDateTime(weatherData.Sys.Sunrise)) + " ;");
            displRitchTxtBox("Zachód słońca: " + System.Convert.ToString(conversionFunction.UnixTimeStampToDateTime(weatherData.Sys.Sunset)) + " ;");
            Picture.ImageLocation = "http://openweathermap.org/img/wn/" + weatherData.Weather[0].Icon + "@4x.png";
            setLabelVisibleStatus(true);
            coordsLabel.Text = "Długość geograficzna: " + System.Convert.ToString(weatherData.Coord.Lon) + Environment.NewLine + "Szerokość geograficzna: " + System.Convert.ToString(weatherData.Coord.Lat);
            cityLabel.Text = weatherData.Name;
            tempLabel.Text = "Temperatura: " + System.Convert.ToString(Math.Truncate((weatherData.Main.Temp - 273) * 100) / 100) + " °C";
            humidityLabel.Text = "Wilgotność: " + System.Convert.ToString(weatherData.Main.Humidity) + "%";
            pressureLabel.Text = "Ciśnienie: " + System.Convert.ToString(weatherData.Main.Pressure);
            sunriseLabel.Text = "Wschód słońca: " + System.Convert.ToString(conversionFunction.UnixTimeStampToDateTime(weatherData.Sys.Sunrise));
            sunsetLabel.Text = "Zachód słońca: " + System.Convert.ToString(conversionFunction.UnixTimeStampToDateTime(weatherData.Sys.Sunset));
            tempminlabel.Text = "Temperatura minimalna: " + System.Convert.ToString(Math.Truncate((weatherData.Main.TempMin - 273) * 100) / 100) + " °C";
            tempmaxlabel.Text = "Temperatura maksymalna: " + System.Convert.ToString(Math.Truncate((weatherData.Main.TempMax - 273) * 100) / 100) + " °C";
            switch (weatherData.Weather[0].Icon)
            {
                case "01d":
                    weatherLabel.Text = "Warunki pogodowe : czyste niebo";
                    break;
                case "02d":
                    weatherLabel.Text = "Warunki pogodowe : lekkie zachmurzenie";
                    break;
                case "03d":
                    weatherLabel.Text = "Warunki pogodowe : pochmurno";
                    break;
                case "04d":
                    weatherLabel.Text = "Warunki pogodowe : średnie zachmurzenie";
                    break;
                case "09d":
                    weatherLabel.Text = "Warunki pogodowe : lekki deszcz";
                    break;
                case "10d":
                    weatherLabel.Text = "Warunki pogodowe : deszcz";
                    break;
                case "11d":
                    weatherLabel.Text = "Warunki pogodowe : burza";
                    break;
                case "13d":
                    weatherLabel.Text = "Warunki pogodowe : śnieg";
                    break;
                case "50d":
                    weatherLabel.Text = "Warunki pogodowe : mgła";
                    break;
                case "01n":
                    weatherLabel.Text = "Warunki pogodowe : czyste niebo";
                    break;
                case "02n":
                    weatherLabel.Text = "Warunki pogodowe : lekkie zachmurzenie";
                    break;
                case "03n":
                    weatherLabel.Text = "Warunki pogodowe : pochmurno";
                    break;
                case "04n":
                    weatherLabel.Text = "Warunki pogodowe : średnie zachmurzenie";
                    break;
                case "09n":
                    weatherLabel.Text = "Warunki pogodowe : lekki deszcz";
                    break;
                case "10n":
                    weatherLabel.Text = "Warunki pogodowe : deszcz";
                    break;
                case "11n":
                    weatherLabel.Text = "Warunki pogodowe : burza";
                    break;
                case "13n":
                    weatherLabel.Text = "Warunki pogodowe : śnieg";
                    break;
                case "50n":
                    weatherLabel.Text = "Warunki pogodowe : mgła";
                    break;
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            string getDataUrl = makeRequestUrl(SelectCity.LastSelectedCity);
            jsonWeatherRichTxtBox.Clear();
            getJsonData(getDataUrl);
        }

        private void oPorogramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program służy do pokazywania progrnozy pogody przy użyciu API https://openweathermap.org/api");
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autorem programu jest Andrzej Robakiewicz");
        }

         private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.Visible = false;
            }
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            axWindowsMediaPlayer1.close();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            displJsonDataCheckBox.Visible = true;
            string getDataUrl = makeRequestUrl(SelectCity.LastSelectedCity);
            jsonWeatherRichTxtBox.Clear();
            getJsonData(getDataUrl);
        }

        private void białegostokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 0;
        }

        private void bydgoszczyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 1;
        }

        private void gdańskaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 2;
        }

        private void gorzowaWielkopolskiegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 3;
        }

        private void katowicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 4;
        }

        private void kielcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 5;
        }

        private void krakowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 6;
        }

        private void lublinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 7;
        }

        private void łodziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 8;
        }

        private void mińskaMazowieckiegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 9;
        }

        private void olsztynaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 10;
        }

        private void opolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 11;
        }

        private void poznaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 12;
        }

        private void rzeszowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 13;
        }

        private void zczecinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 14;
        }

        private void warszawyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 15;
        }

        private void wrocławiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cities.SelectedIndex = 16;
        }

        private void setLabelVisibleStatus(bool status)
        {
            coordsLabel.Visible = status;
            cityLabel.Visible = status;
            tempLabel.Visible = status;
            humidityLabel.Visible = status;
            pressureLabel.Visible = status;
            sunriseLabel.Visible = status;
            sunsetLabel.Visible = status;
            weatherLabel.Visible = status;
            tempminlabel.Visible = status;
            tempmaxlabel.Visible = status;
            Picture.Visible = status;
        }

        private void Pogoda_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.BringToFront();
            jsonWeatherRichTxtBox.LanguageOption = RichTextBoxLanguageOptions.DualFont;
        }

        private void displJsonDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (displJsonDataCheckBox.Checked == true)
            {
                jsonWeatherRichTxtBox.Enabled = true;
                this.Size = new Size(windowSize.windowWithJsonDataWidth, windowSize.windowWithJsonDataLength);
            }
            else
            {
                jsonWeatherRichTxtBox.Enabled = false;
                this.Size = new Size(windowSize.windowWithoutJsonDataWidht, windowSize.windowWithoutJsonDataLength);
            }
        }
    }
}
