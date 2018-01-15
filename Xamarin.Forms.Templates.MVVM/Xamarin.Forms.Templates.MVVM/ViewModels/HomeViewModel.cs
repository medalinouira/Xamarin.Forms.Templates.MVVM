/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System;
using Xamarin.Forms;
using System.Windows.Input;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Navigation;
using System.Collections.Generic;
using Xamarin.Forms.Templates.MVVM.Models;
using Xamarin.Forms.Templates.MVVM.IViewModels;

namespace Xamarin.Forms.Templates.MVVM.ViewModels
{
    public class HomeViewModel : BaseViewModel, IHomeViewModel
    {
        private readonly INavigationService _iNavigationService;

        private String _welcomeText;
        public String WelcomeText
        {
            get { return _welcomeText; }
            set
            {
                _welcomeText = value;
                OnPropertyChanged(nameof(WelcomeText));
            }
        }

        public ICommand NavigateToCommand { get; set; }

        [Preserve]
        public HomeViewModel()
        {
            this._iNavigationService = DependencyService.Get<INavigationService>(DependencyFetchTarget.GlobalInstance);
            NavigateToCommand = new Command<String>(NavigateTo);

            WelcomeText = "Welcome to Empty MVVM App !";
        }

        private async void NavigateTo(string param)
        {
            var navigationParams = new NavigationParameters();
            var MySampleModel = new SampleModel() { Id = 0, Name = "Empty MVVM App Parameter", Items = new List<string>() { "Items 1", "Item 2", "Item 3" } };

            navigationParams.Add(nameof(SampleModel), MySampleModel);
            await _iNavigationService.NavigateTo(param, navigationParams);
        }
    }
}
