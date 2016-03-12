using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using NewsReader.Shared.Services;
using NewsReader.Shared.ViewModels;
using DialogService = NewsReader.Android.Services.DialogService;
using IDialogService = NewsReader.Shared.Services.IDialogService;

namespace NewsReader.Android.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public static class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<IDialogService, DialogService>();
            SimpleIoc.Default.Register<IRssService, RssService>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public static MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();
    }
}