using GalaSoft.MvvmLight;

namespace Privat24Info.ViewModels
{
    public class PageViewModelBase : ViewModelBase
    {
        private bool _isBusy;
        public virtual bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisePropertyChanged();
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; RaisePropertyChanged(); }
        }
    }
}
