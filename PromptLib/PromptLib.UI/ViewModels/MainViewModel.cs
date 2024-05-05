using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptLib.UI.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject _currentView;

        public MainViewModel()
        {
            _currentView = new LibraryViewModel();
        }

        [RelayCommand]
        private void NavigateToLibrary()
        {
            CurrentView = new LibraryViewModel();
        }

        [RelayCommand]
        private void NavigateToBuildPrompt()
        {
            CurrentView = new BuildPromptViewModel();
        }

        [RelayCommand]
        private void NavigateToSettings()
        {
            CurrentView = new SettingsViewModel();
        }
    }
}
