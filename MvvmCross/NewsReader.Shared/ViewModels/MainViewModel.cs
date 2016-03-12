using System.Collections.Generic;
using System.Collections.ObjectModel;
using MvvmCross.Core.ViewModels;
using NewsReader.Shared.Models;
using NewsReader.Shared.Services;

namespace NewsReader.Shared.ViewModels
{
    public class MainViewModel : MvxViewModel
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
            set
            {
                _news = value;
                RaisePropertyChanged();
            }
        }

        private MvxCommand _loadCommand;

        public MvxCommand LoadCommand
        {
            get
            {
                if (_loadCommand == null)
                {
                    _loadCommand = new MvxCommand(async () =>
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

        private MvxCommand<FeedItem> _itemSelectedCommand;

        public MvxCommand<FeedItem> ItemSelectedCommand
        {
            get
            {
                if (_itemSelectedCommand == null)
                {
                    _itemSelectedCommand = new MvxCommand<FeedItem>(async args =>
                    {
                        await _dialogService.ShowDialogAsync(args.Title);
                    });
                }

                return _itemSelectedCommand;
            }
        }
    }
}
