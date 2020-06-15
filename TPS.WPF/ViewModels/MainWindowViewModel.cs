using System.Collections.Generic;
using ModernWpf.Controls;
using Stylet;
using StyletIoC;
using TPS.WPF.Views;

namespace TPS.WPF.ViewModels
{
    public class MainWindowViewModel : Conductor<IScreen>.StackNavigation
    {
        private readonly Stack<NavigationViewItem> _history = new Stack<NavigationViewItem>();

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
            navView.SelectionChanged += Navigate;
            navView.BackRequested += NavigateBack;
        }

        private void NavigateBack(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            GoBack();

            // Work around to select the navigation item that this
            // IScreen is a part of
            _history.Pop();
            sender.SelectedItem = _history.Pop();
            sender.IsBackEnabled = _history.Count > 1;
        }

        private void Navigate(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                ActivateItem(SettingsPage);
                _history.Push((NavigationViewItem) sender.SettingsItem);
            }
            else if ((args.SelectedItem as NavigationViewItem)?.Tag is IScreen viewModel)
            {
                ActivateItem(viewModel);
                _history.Push((NavigationViewItem) sender.SelectedItem);
            }

            sender.IsBackEnabled = _history.Count > 1;
        }
    }
}