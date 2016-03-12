using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Basic.Shared.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                Set(ref _name, value);
                SayHello.RaiseCanExecuteChanged();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { Set(ref _message, value); }
        }

        private RelayCommand _sayHello;

        public RelayCommand SayHello
        {
            get
            {
                if (_sayHello == null)
                {
                    _sayHello = new RelayCommand(() =>
                    {
                        Message = $"Hello {Name}";
                    }, () => !string.IsNullOrEmpty(Name));
                }

                return _sayHello;
            }
        }
    }
}