using Refit;
using LegendsRank.Models;
using LegendsRank.Services;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Prism;
using Prism.Unity;
using Prism.Ioc;

namespace LegendsRank.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ICommand GetSummonerCommand { get; }

        public string SummonerName { get; set; }

        ISummonerAPIService summonerapiService;

        public Summoner Summoner { get; set; }

        public MainPageViewModel()
        {
            summonerapiService = new SummonerApiService();
            GetSummonerCommand = new Command(GetSummonerAsync);
        }

        private async void GetSummonerAsync()
        {
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var serviceApi = RestService.For<SummonerAPI>("https://na1.api.riotgames.com");
                var summoner = await summonerapiService.GetSummonerAsync(SummonerName);

                Summoner = summoner;
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("No Internet", "It looks like you don't have internet, please connect and try again.", "Ok");
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}