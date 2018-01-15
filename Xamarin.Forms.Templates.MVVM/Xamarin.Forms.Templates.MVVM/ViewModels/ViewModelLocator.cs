/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;
using Xamarin.Forms.Navigation;
using Xamarin.Forms.Templates.MVVM.IViewModels;

namespace Xamarin.Forms.Templates.MVVM.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            DependencyService.Register<IHomeViewModel, HomeViewModel>();
            DependencyService.Register<IDetailsViewModel, DetailsViewModel>();

            DependencyService.Register<INavigationService, NavigationService>();
        }

        public IHomeViewModel Home
        {
            get
            {
                return DependencyService.Get<IHomeViewModel>();
            }
        }

        public IDetailsViewModel Details
        {
            get
            {
                return DependencyService.Get<IDetailsViewModel>();
            }
        }
    }
}
