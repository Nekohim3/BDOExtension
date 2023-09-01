using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDOExtensions.Utils;
using ReactiveUI;

namespace BDOExtensions.ViewModels.Settings
{
    public class SettingsViewModel : ViewModelBase
    {
        #region System

        private bool _transparentWhenNotBdo;
        public bool TransparentWhenNotBdo
        {
            get => _transparentWhenNotBdo;
            set => this.RaiseAndSetIfChanged(ref _transparentWhenNotBdo, value);
        }

        private int _transparentLevelWhenNotBdo;
        public int TransparentLevelWhenNotBdo
        {
            get => _transparentLevelWhenNotBdo;
            set => this.RaiseAndSetIfChanged(ref _transparentLevelWhenNotBdo, value);
        }

        private bool _transparentLevel;
        public bool TransparentLevel
        {
            get => _transparentLevel;
            set => this.RaiseAndSetIfChanged(ref _transparentLevel, value);
        }

        private ObservableCollectionWithSelectedItemNumber<int> _screenIndex;
        public ObservableCollectionWithSelectedItemNumber<int> ScreenIndex
        {
            get => _screenIndex;
            set => this.RaiseAndSetIfChanged(ref _screenIndex, value);
        }

        private ObservableCollectionWithSelectedItemNumber<int> _adapterIndex;
        public ObservableCollectionWithSelectedItemNumber<int> AdapterIndex
        {
            get => _adapterIndex;
            set => this.RaiseAndSetIfChanged(ref _adapterIndex, value);
        }

        private bool _staticDelay;
        public bool StaticDelay
        {
            get => _staticDelay;
            set => this.RaiseAndSetIfChanged(ref _staticDelay, value);
        }

        private int _delayValue;
        public int DelayValue
        {
            get => _delayValue;
            set => this.RaiseAndSetIfChanged(ref _delayValue, value);
        }

        #endregion



        public SettingsViewModel()
        {

        }
    }
}
