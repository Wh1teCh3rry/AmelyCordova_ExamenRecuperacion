using Newtonsoft.Json;
using System.Net;
using AmelyCordova_ExamenRecuperacion.ACModels;

namespace AmelyCordova_ExamenRecuperacion;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public async void ACButton_Clicked(object sender, EventArgs e)
    {
        WebRequest request1 = WebRequest.Create("https://dog.ceo/api/breed/pomeranian/images");
        request1.Headers.Add("Accept", "application/json");
        WebResponse response1 = request1.GetResponse();
        using (Stream dataStream = response1.GetResponseStream())
        {
            StreamReader reader1 = new StreamReader(dataStream);
            string responseFromServer1 = reader1.ReadToEnd();
            responseFromServer1 = responseFromServer1.Trim();
            var resultado1 = JsonConvert.DeserializeObject<Root>(responseFromServer1);
            string imagen1 = resultado1.message[0];
            string imagen2 = resultado1.message[1];
            string imagen3 = resultado1.message[2];
            string imagen4 = resultado1.message[3];
            string imagen5 = resultado1.message[4];
            string imagen6 = resultado1.message[5];
            string imagen7 = resultado1.message[6];
            string imagen8 = resultado1.message[7];
            string imagen9 = resultado1.message[8];
            string imagen10 = resultado1.message[9];
            string imagen11 = resultado1.message[10];
            string imagen12 = resultado1.message[11];
            string imagen13 = resultado1.message[12];
            string imagen14 = resultado1.message[13];
            string imagen15 = resultado1.message[14];
            string imagen16 = resultado1.message[15];
            string imagen17 = resultado1.message[16];
            string imagen18 = resultado1.message[17];
            string imagen19 = resultado1.message[18];
            string imagen20 = resultado1.message[19];
            ACimage1.Source = imagen1;
            ACimage2.Source = imagen2;
            ACimage3.Source = imagen3;
            ACimage4.Source = imagen4;
            ACimage5.Source = imagen5;
            ACimage6.Source = imagen6;
            ACimage7.Source = imagen7;
            ACimage8.Source = imagen8;
            ACimage9.Source = imagen9;
            ACimage10.Source = imagen10;
            ACimage11.Source = imagen11;
            ACimage12.Source = imagen12;
            ACimage13.Source = imagen13;
            ACimage14.Source = imagen14;
            ACimage15.Source = imagen15;
            ACimage16.Source = imagen16;
            ACimage17.Source = imagen17;
            ACimage18.Source = imagen18;
            ACimage19.Source = imagen19;
            ACimage20.Source = imagen20;
        }
    }
}