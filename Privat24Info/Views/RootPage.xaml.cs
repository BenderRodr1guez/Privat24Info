using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Privat24Info.Views
{
    public sealed partial class RootPage : Page
    {
        public RootPage()
        {
            this.InitializeComponent();
            Frame.Content = new ATMsPage();
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void UIElement_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            
        }
    }
}
