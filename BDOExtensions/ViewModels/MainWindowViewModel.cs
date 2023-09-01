using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDOExtensions.ViewModels.Settings;

namespace BDOExtensions.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private MainOverlayViewModel _overlayViewModel;
        public MainOverlayViewModel OverlayViewModel
        {
            get => _overlayViewModel;
            set => this.RaiseAndSetIfChanged(ref _overlayViewModel, value);
        }

        private SettingsViewModel _settingsViewModel;
        public SettingsViewModel SettingsViewModel
        {
            get => _settingsViewModel;
            set => this.RaiseAndSetIfChanged(ref _settingsViewModel, value);
        }

        public MainWindowViewModel()
        {
            OverlayViewModel  = new MainOverlayViewModel();
            SettingsViewModel = new SettingsViewModel();
        }
    }
}
