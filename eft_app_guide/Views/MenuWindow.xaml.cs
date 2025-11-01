using eft_app_guide.Attributes;
using eft_app_guide.Models.Enums;
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
            this.viewmodel = viewmodel;

            PositionWindow(this.viewmodel.MenuPosition);
            this.DataContext = this.viewmodel;
        }

        private void PositionWindow(MenuPosition position)
        {
            if (position == MenuPosition.LeftCenter ||  position == MenuPosition.RightCenter)
            {
                this.Height = SystemParameters.PrimaryScreenHeight;
                this.Width = 60;
                this.Top = 0;

                if (position == MenuPosition.LeftCenter) this.Left = 0;
                else this.Left = SystemParameters.PrimaryScreenWidth - 60;
            }
            else if (position == MenuPosition.TopCenter || position == MenuPosition.BottomCenter)
            {
                this.Width = SystemParameters.PrimaryScreenWidth;
                this.Height = 60;
                this.Left = 0;

                if (position == MenuPosition.TopCenter) this.Top = 0;
                else this.Top = SystemParameters.PrimaryScreenHeight - 60;
            }
        }
    }
}
