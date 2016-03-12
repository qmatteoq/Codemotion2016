using Android.Widget;
using GalaSoft.MvvmLight.Views;
using NewsReader.Android.ViewModels;
using NewsReader.Shared.ViewModels;

namespace NewsReader.Android
{
    public partial class MainActivity: ActivityBase
    {
        public MainViewModel ViewModel => ViewModelLocator.Main;

        private Button _commandButton;
        public Button CommandButton
          => _commandButton ?? (_commandButton = this.FindViewById<Button>(Resource.Id.GetNewsButton));

        private ListView _newsList;
        public ListView NewsList => _newsList ?? (_newsList = this.FindViewById<ListView>(Resource.Id.News));
    }
}