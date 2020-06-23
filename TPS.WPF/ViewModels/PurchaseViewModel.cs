using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ModernWpf.Controls;
using ModernWpf.Controls.Primitives;
using Stylet;
using TPS.Data;
using TPS.Data.Products;
using TPS.WPF.Models;
using TPS.WPF.Views;

namespace TPS.WPF.ViewModels
{
    public class PurchaseViewModel : Screen
    {
        private readonly Dictionary<string, Flyout> _flyouts = new Dictionary<string, Flyout>();
        private Flyout? _flyout;

        protected override void OnViewLoaded()
        {
            var view = ((PurchaseView) View);

            _flyouts[nameof(view.AddCartButton)] = FlyoutService.GetFlyout(view.AddCartButton) as Flyout;
            _flyouts[nameof(view.EmptyCartButton)] = FlyoutService.GetFlyout(view.EmptyCartButton) as Flyout;
        }

        public PurchaseViewModel(TPSContext context) => Products = new BindableCollection<Product>(context.Products);

        public BindableCollection<Product> Products { get; }

        public Cart Cart { get; } = new Cart();

        public Product? SelectedProduct { get; set; } = null!;

        public uint Amount { get; set; } = 1;

        public bool IsLoading { get; set; } = false;

        public bool FlyOutIsOpen { get; set; } = false;

        public void HideFlyout()
        {
            _flyout?.Hide();
        }

        public void EmptyCart() { }

        public async Task AddProduct()
        {
            Cart.AddOrUpdate(SelectedProduct, Amount);

            await ArtificialWaitTime(TimeSpan.FromSeconds(3));
        }

        public async Task ArtificialWaitTime(TimeSpan length)
        {
            IsLoading = true;
            await Task.Delay(TimeSpan.FromSeconds(5));
            IsLoading = false;
            FlyOutIsOpen = false;
        }
    }
}