using RT_GUI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RT_GUI.ViewModels
{
    public class PlayerCountViewModel : ViewModel
    {
        public PlayerCountViewModel()
        {
            OnPageLoad();
        }
        public int playerCount = 0;
        public int SliderValue { get; set; }
        public ObservableCollection<PLayerViewModel> MyProperty { get; set; }
        public ICommand OnButtonClicked => new Command(async () =>
        {
            await Navigation.PushAsync(Resolver.Resolve<PlayerSetupView>());
        });
        private void OnPageLoad()
        {
            CreatePlayer();
        }
        private void CreatePlayer()
        {

        }
    }
}
