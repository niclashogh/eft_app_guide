using eft_app_guide.Attributes;
using eft_app_guide.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace eft_app_guide.Views
{
    [DependencyInjectionRegister(ServiceLifetime.Scoped)]
    public partial class MenuWindow : Window
    {
        private readonly MenuVM viewmodel;

        public MenuWindow(MenuVM viewmodel)
        {
            InitializeComponent();
            this.Height = SystemParameters.PrimaryScreenHeight;

            this.viewmodel = viewmodel;
            this.DataContext = this.viewmodel;
        }
    }
}
