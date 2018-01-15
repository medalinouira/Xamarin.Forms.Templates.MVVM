/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;
using System.Windows.Input;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Navigation;
using Xamarin.Forms.Templates.MVVM.Models;
using Xamarin.Forms.Templates.MVVM.IViewModels;

namespace Xamarin.Forms.Templates.MVVM.ViewModels
{
    public class DetailsViewModel : BaseViewModel, IDetailsViewModel
    {
        private readonly INavigationService _iNavigationService;

        private SampleModel _mySampleModel;
        public SampleModel MySampleModel
        {
            get { return _mySampleModel; }
            set
            {
                _mySampleModel = value;
                OnPropertyChanged(nameof(MySampleModel));
            }
        }

        public ICommand SelectedItemCommand { get; set; }

        [Preserve]
        public DetailsViewModel()
        {
            this._iNavigationService = DependencyService.Get<INavigationService>(DependencyFetchTarget.GlobalInstance);
            MySampleModel = _iNavigationService.GetParameters().GetValue<SampleModel>(nameof(SampleModel));

            SelectedItemCommand = new Command<string>(SelectedItem);
        }

        private void SelectedItem(string param)
        {
            App.Current.MainPage.DisplayAlert("SelectedItem", param, "Ok");
        }
    }
}
