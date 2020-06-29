using Microsoft.EntityFrameworkCore;
using Stylet;
using StyletIoC;
using TPS.Data;
using TPS.WPF.ViewModels;

namespace TPS.WPF
{
    public class Bootstrapper : Bootstrapper<MainWindowViewModel>
    {
        protected override void ConfigureIoC(IStyletIoCBuilder builder)
        {
            builder.Bind<TPSContext>().ToFactory(
                container =>
                {
                    var options = new DbContextOptionsBuilder<TPSContext>()
                        .UseSqlite(@"Data Source=.\master_data.db")
                        .Options;

                    return new TPSContext(options);
                });
        }
    }
}