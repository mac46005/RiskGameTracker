using RT_GUI.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RT_GUI.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {

        }
        
        public ICommand OnContinueClick => new Command(async () =>
        {

        });
        public ICommand OnNewGameClick => new Command(async () =>
        {
            var view = Resolver.Resolve<PlayerCountView>();
            await Navigation.PushAsync(view);
        });
    }
}
