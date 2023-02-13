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

    public async void Button_Clicked(object sender, EventArgs e)
    {
        var request = new HttpRequestMessage();
        request.RequestUri = new Uri("https://dog.ceo/api/breed/Pomeranian/images/random");
        request.Method = HttpMethod.Get;
        request.Headers.Add("Accept", "application/json"); var client = new HttpClient(); HttpResponseMessage response = await client.SendAsync(request);
        if (response.StatusCode == HttpStatusCode.OK)
        {
            String content = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<List<Root>>(content);
            ListaDog.ItemsSource = resultado;
        }
    }
}

