using System;
using System.Windows.Controls;
using ModernWpf.Controls;
using Stylet;
using TPS.Data;
using TPS.Data.Products;
using TPS.WPF.Models;
using TPS.WPF.Views;

namespace TPS.WPF.ViewModels
{
    public class PurchaseViewModel : Screen
    {
        private PurchaseView _view;

        public PurchaseViewModel(TPSContext context)
        {
            Products = new BindableCollection<Product>(context.Products);
        }

        public BindableCollection<Product> Products { get; }

        public static Cart Cart { get; } = new Cart();

        public Product? SelectedProduct { get; set; } = null!;

        public uint Amount { get; set; }

        protected override void OnViewLoaded()
        {
            _view = (PurchaseView) View;
        }

        public void HideFlyout(Func<PurchaseView, Button> button)
        {
            var flyOut = FlyoutService.GetFlyout(button(_view)) as Flyout;
            flyOut?.Hide();
        }

        public void EmptyCart(object parent)
        {
            HideFlyout(b => b.EmptyCartButton);
        }

        public void AddProduct()
        {
            if (SelectedProduct is null)
                return;

            Cart.AddOrUpdate(SelectedProduct, Amount);
        }
    }
}