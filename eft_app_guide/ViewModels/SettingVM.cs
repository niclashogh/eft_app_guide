using eft_app_guide.Models;
using eft_app_guide.Services;
using eft_app_guide.ViewModels.ToUserControls;
using eft_app_guide.ViewModels.ToUserControls.BTRs;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eft_app_guide.ViewModels
{
    [DIAutoRegister(ServiceLifetime.Transient)]
    public class SettingVM : BaseVM
    {
        #region [Current User Control] Variable & Properties
        private object currentUserControl = Pages.First().Component;
        public object CurrentUserControl
        {
            get { return currentUserControl; }
            set
            {
                if (currentUserControl == value) return;
                currentUserControl = value;
                OnPropertyChanged(nameof(CurrentUserControl));
            }
        }
        #endregion

        #region [Management Pages] Variables & Properties
        public static List<ViewRecord<object>> ManagementPages { get; } = new List<ViewRecord<object>>
        {
            new(new ItemManagementVM(), "Item Management"),
            // ...
        };

        private ViewRecord<object> selectedManagementPage;
        public ViewRecord<object> SelectedManagementPage
        {
            get { return selectedManagementPage; }
            set
            {
                if (selectedManagementPage == value) return;
                selectedManagementPage = value;
                OnPropertyChanged(nameof(SelectedManagementPage));
            }
        }
        #endregion

        #region [Pages] Variables & Properties
        public static List<ViewRecord<object>> Pages { get; } = new List<ViewRecord<object>>
        {
            new(new SettingHomeVM(), "Home"),
            new(new BTRListingVM(), "BTR"),
            // ...
        };

        private ViewRecord<object> selectedPage = Pages.First();
        public ViewRecord<object> SelectedPage
        {
            get { return selectedPage; }
            set
            {
                if (selectedPage == value) return;
                selectedPage = value;
                OnPropertyChanged(nameof(SelectedPage));
            }
        }
        #endregion

        public SettingVM()
        {
            
        }
    }
}
