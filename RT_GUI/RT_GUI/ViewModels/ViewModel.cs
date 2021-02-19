using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RT_GUI.ViewModels
{
    public abstract class ViewModel : NavigationViewModel,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(params string[] propertyNames)
        {
            foreach (var propertyName in propertyNames)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
