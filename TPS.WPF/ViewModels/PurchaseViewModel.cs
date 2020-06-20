using Stylet;
using TPS.Data;
using TPS.Data.Products;

namespace TPS.WPF.ViewModels
{
    public class PurchaseViewModel : Screen
    {
        public PurchaseViewModel(TPSContext context) => Products = new BindableCollection<Product>(context.Products);

        public BindableCollection<Product> Products { get; }

        public Product SelectedProduct { get; set; }

        public void EmptyCart() { }
    }
}