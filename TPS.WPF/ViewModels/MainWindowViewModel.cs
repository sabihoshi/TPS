using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Navigation;
using ModernWpf.Controls;
using ModernWpf.Navigation;
using Stylet;
using TPS.WPF.Views;
using Frame = ModernWpf.Controls.Frame;

namespace TPS.WPF.ViewModels
{
    public class MainWindowViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public TestViewModel Test { get; set;  } = new TestViewModel();

        protected override void OnViewLoaded()
        {
            ((MainWindowView)View).NavView.SelectionChanged += NavViewOnSelectionChanged;
        }

        private void NavViewOnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if(((NavigationViewItem) args.SelectedItem).Tag is IScreen viewModel)
                ActivateItem(viewModel);
        }

        private NavigationViewItem _selectedNavItem;

        public NavigationViewItem SelectedNavItem
        {
            get => _selectedNavItem;
            set => SetAndNotify(ref _selectedNavItem, value);
        }


        private Type GetPageType(NavigationViewItem item)
        {
            return item.Tag as Type;
        }
    }
}