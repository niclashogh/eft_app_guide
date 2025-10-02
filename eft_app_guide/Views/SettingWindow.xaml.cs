using eft_app_guide.Attributes;
using eft_app_guide.ViewModels;
using eft_app_guide.ViewModels.ToUserControls.BTRs;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace eft_app_guide.Views
{
    [DependencyInjectionRegister(ServiceLifetime.Transient)]
    public partial class SettingWindow : Window
    {
        private readonly SettingVM viewmodel;

        public SettingWindow(SettingVM viewmodel)
        {
            InitializeComponent();
            this.viewmodel = viewmodel;
            this.DataContext = this.viewmodel;
        }
    }
}
