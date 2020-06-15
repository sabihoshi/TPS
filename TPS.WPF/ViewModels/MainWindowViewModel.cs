using ModernWpf.Controls;
using Stylet;
using StyletIoC;
using TPS.WPF.Views;

namespace TPS.WPF.ViewModels
{
    public class MainWindowViewModel : Conductor<IScreen>.StackNavigation
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
            // Terrible work around because the events do not conform
            // to the signatures Stylet supports
            var navView = ((MainWindowView) View).NavView;
            navView.SelectionChanged += NavViewOnSelectionChanged;
            navView.BackRequested += NavViewOnBackRequested;
        }

        private void NavViewOnBackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            GoBack();
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