using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using dadjokexam.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace dadjoke_xam.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        DadJoke DadJokeItem;
        private string joke = "Press the button for dad jokes!";
        public string Joke
        {
            get { return joke; }
            set { SetProperty(ref joke, value); }
        }
        private readonly HttpClient client;

        public ICommand FetchDadJoke { private set; get; }

        public HomeViewModel()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            Title = "Home";
            FetchDadJoke = new Command(async () =>
            {

                try
                {
                    Uri uri = new Uri(string.Format("https://icanhazdadjoke.com/", string.Empty));
                    HttpResponseMessage response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        DadJokeItem = JsonConvert.DeserializeObject<DadJoke>(content);
                        Joke = DadJokeItem.Joke;
                    }
                    else
                    {
                        Console.WriteLine("Fetching API not successful");
                        Console.WriteLine(response.Content);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

               
            });
        }


    }
}
