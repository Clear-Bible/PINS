
using Pins.Core.ViewModels;
using MvvmCross.ViewModels;

namespace Pins.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<StartupViewModel>();
        }
    }
}
