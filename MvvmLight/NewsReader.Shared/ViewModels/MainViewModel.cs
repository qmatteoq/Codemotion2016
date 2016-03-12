using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NewsReader.Shared.Models;
using NewsReader.Shared.Services;

namespace NewsReader.Shared.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IRssService _rssService;
        private readonly IDialogService _dialogService;

        public MainViewModel(IRssService rssService, IDialogService dialogService)
        {
            _rssService = rssService;
            _dialogService = dialogService;
            News = new ObservableCollection<FeedItem>();
        }

        private ObservableCollection<FeedItem> _news;

        public ObservableCollection<FeedItem> News
        {
            get { return _news; }
            set { Set(ref _news, value); }
        }

        private RelayCommand _loadCommand;

        public RelayCommand LoadCommand
        {
            get
            {
                if (_loadCommand == null)
                {
                    _loadCommand = new RelayCommand(async () =>
                    {
                        List<FeedItem> items = await _rssService.GetNews("http://blog.qmatteoq.com/rss");
                        foreach (FeedItem feedItem in items)
                        {
                            News.Add(feedItem);
                        }
                    });
                }

                return _loadCommand;
            }
        }

        private RelayCommand<FeedItem> _itemSelectedCommand;

        public RelayCommand<FeedItem> ItemSelectedCommand
        {
            get
            {
                if (_itemSelectedCommand == null)
                {
                    _itemSelectedCommand = new RelayCommand<FeedItem>(async args =>
                    {
                        await _dialogService.ShowDialogAsync(args.Title);
                    });
                }

                return _itemSelectedCommand;
            }
        }
    }
}
