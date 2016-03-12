using Basic.Shared.ViewModels;

namespace Basic.Android.ViewModels
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
            
        }

        private static MainViewModel _mainViewModel;
        public static MainViewModel Main => _mainViewModel ?? (_mainViewModel = new MainViewModel());
    }
}