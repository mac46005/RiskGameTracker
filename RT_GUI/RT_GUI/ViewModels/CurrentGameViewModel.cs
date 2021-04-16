using RT_GUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace RT_GUI.ViewModels
{
    public class CurrentGameViewModel : ViewModel
    {
        public CurrentGameViewModel()
        {
        }
        public ObservableCollection<PLayerViewModel> PlayerViewList { get; set; } = new ObservableCollection<PLayerViewModel>();
    }
}
