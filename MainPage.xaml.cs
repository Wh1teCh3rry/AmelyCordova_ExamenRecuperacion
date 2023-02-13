using Newtonsoft.Json;
using System.Net;
using AmelyCordova_ExamenRecuperacion.ACModels;

namespace AmelyCordova_ExamenRecuperacion;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    public async void ACButton_Clicked(object sender, EventArgs e)
    {
        WebRequest request1 = WebRequest.Create("https://dog.ceo/api/breed/Pomeranian/images/random/10");
        request1.Headers.Add("Accept", "application/json");
        WebResponse response1 = request1.GetResponse();
        using (Stream dataStream = response1.GetResponseStream())
        {
            StreamReader reader1 = new StreamReader(dataStream);
            string responseFromServer1 = reader1.ReadToEnd();
            responseFromServer1 = responseFromServer1.Trim();
            var resultado1 = JsonConvert.DeserializeObject<Root>(responseFromServer1);
            string imagen = resultado1.status;
            ACimage1.Source = imagen;
            ACimage2.Source = imagen;
            ACimage3.Source = imagen;
            ACimage4.Source = imagen;
            ACimage5.Source = imagen;
            ACimage6.Source = imagen;
            ACimage7.Source = imagen;
            ACimage8.Source = imagen;
            ACimage9.Source = imagen;
            ACimage10.Source = imagen;
        }
    }
}
