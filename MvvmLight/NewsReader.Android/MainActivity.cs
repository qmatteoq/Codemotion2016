using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using NewsReader.Shared.Models;

namespace NewsReader.Android
{
    [Activity(Label = "NewsReader.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class MainActivity : AdapterView.IOnItemClickListener
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            CommandButton.SetCommand("Click", ViewModel.LoadCommand);
            NewsList.Adapter = ViewModel.News.GetAdapter(GetNewsAdapter);
            NewsList.OnItemClickListener = this;
        }

        private View GetNewsAdapter(int position, FeedItem item, View row)
        {
            if (row == null)
            {
                row = LayoutInflater.Inflate(Resource.Layout.newstemplate, null);
            }

            var title = row.FindViewById<TextView>(Resource.Id.title);
            title.Text = item.Title;

            return row;
        }
      
        public void OnItemClick(AdapterView parent, View view, int position, long id)
        {
            ViewModel.ItemSelectedCommand.Execute(ViewModel.News[position]);
        }
    }
}

