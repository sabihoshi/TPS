using System;
using ModernWpf;
using ModernWpf.Controls;
using ModernWpf.Media.Animation;

namespace TPS.WPF.ModernWPF
{
    public class TPSNavigationView : NavigationView
    {
        public new event TypedEventHandler<object, NavigationViewItemInvokedEventArgs> ItemInvoked;
    }

    public class ItemInvokedEventArgs : EventArgs
    {
        public object InvokedItem { get; internal set; }

        public bool IsSettingsInvoked { get; internal set; }

        public NavigationViewItemBase InvokedItemContainer { get; internal set; }

        public NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; internal set; }
    }
}