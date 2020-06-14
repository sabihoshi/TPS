using ModernWpf.Controls;
using Stylet;
using StyletIoC;
using TPS.WPF.Views;

namespace TPS.WPF.ViewModels
{
    public class MainWindowViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public MainWindowViewModel(IContainer ioc)
        {
            SettingsPage = ioc.Get<SettingsPageViewModel>();
            ProductsView = ioc.Get<ProductsViewModel>();
        }

        public IScreen SettingsPage { get; }

        public IScreen ProductsView { get; }

        protected override void OnViewLoaded()
        {
            var navView = ((MainWindowView) View).NavView;
            navView.SelectionChanged += NavViewOnSelectionChanged;
        }

        private void NavViewOnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
                ActivateItem(SettingsPage);
            else if (((NavigationViewItem) args.SelectedItem).Tag is IScreen viewModel)
                ActivateItem(viewModel);
        }
    }
}