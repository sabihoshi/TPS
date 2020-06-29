using System;
using System.Globalization;
using System.Windows.Data;
using Stylet;
using TPS.Data;
using TPS.Data.Products;

namespace TPS.WPF.ViewModels
{
    public class ProductsViewModel : Screen
    {
        public ProductsViewModel(TPSContext context)
        {
            Products = new BindableCollection<Product>(context.Products);
        }

        public BindableCollection<Product> Products { get; }
    }

    public class ProductGroupKeyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            ((string) value).Substring(0, 1).ToUpper();

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotImplementedException();
    }
}