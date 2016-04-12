using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace Privat24Info.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<RootPageViewModel>();
        }

        public RootPageViewModel Root => ServiceLocator.Current.GetInstance<RootPageViewModel>();
    }
}
