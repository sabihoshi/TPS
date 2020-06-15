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
        private NavigationView _navView;

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
            _navView = ((MainWindowView) View).NavView;
            _navView.SelectionChanged += NavViewOnSelectionChanged;
            _navView.BackRequested += (sender, args) => NavigateBack();
        }

        private void NavigateBack()
        {
            GoBack();

            // Work around to select the navigation item that this
            // IScreen is a part of
            _history.Pop();
            _navView.SelectedItem = _history.Pop();
            _navView.IsBackEnabled = _history.Count > 1;
        }

        private void NavViewOnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                ActivateItem(SettingsPage);
                _history.Push((NavigationViewItem) _navView.SettingsItem);
            }
            else if ((args.SelectedItem as NavigationViewItem)?.Tag is IScreen viewModel)
            {
                ActivateItem(viewModel);
                _history.Push((NavigationViewItem) _navView.SelectedItem);
            }

            _navView.IsBackEnabled = _history.Count > 1;
        }
    }
}