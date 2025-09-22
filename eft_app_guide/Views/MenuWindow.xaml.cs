using eft_app_guide.Services;
using eft_app_guide.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace eft_app_guide.Views
{
    [DIAutoRegister(ServiceLifetime.Scoped)]
    public partial class MenuWindow : Window
    {
        private MenuVM viewmodel { get; set; }

        public MenuWindow(MenuVM vm)
        {
            InitializeComponent();
            this.Height = SystemParameters.PrimaryScreenHeight;

            this.viewmodel = vm;
            this.DataContext = viewmodel;
        }
    }
}
