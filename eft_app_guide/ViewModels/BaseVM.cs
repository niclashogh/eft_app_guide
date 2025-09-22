using eft_app_guide.Services;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace eft_app_guide.ViewModels
{
    public class BaseVM : NotifyChangedService
    {
        public bool IsAdminstrator()
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
