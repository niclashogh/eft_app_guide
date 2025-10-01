using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace eft_app_guide.ViewModels
{
    public class BaseVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool IsAdminstrator()
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return false;

            using (WindowsIdentity id = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(id);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
