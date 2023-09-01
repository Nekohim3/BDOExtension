using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace BDOExtensions.ViewModels
{
    public class MainOverlayViewModel : ViewModelBase
    {
        private string _bossAlert;
        public string BossAlert
        {
            get => _bossAlert;
            set => this.RaiseAndSetIfChanged(ref _bossAlert, value);
        }

        private bool _alch;
        public bool Alch
        {
            get => _alch;
            set => this.RaiseAndSetIfChanged(ref _alch, value);
        }

        private bool _food;
        public bool Food
        {
            get => _food;
            set => this.RaiseAndSetIfChanged(ref _food, value);
        }

        private bool _stone;
        public bool Stone
        {
            get => _stone;
            set => this.RaiseAndSetIfChanged(ref _stone, value);
        }

        private bool _shelter;
        public bool Shelter
        {
            get => _shelter;
            set => this.RaiseAndSetIfChanged(ref _shelter, value);
        }

        private bool _balm;
        public bool Balm
        {
            get => _balm;
            set => this.RaiseAndSetIfChanged(ref _balm, value);
        }

        private DateTime _currentTime;
        public DateTime CurrentTime
        {
            get => _currentTime;
            set => this.RaiseAndSetIfChanged(ref _currentTime, value);
        }

        public MainOverlayViewModel()
        {
            _bossAlert  = "Нубер / Каранда (00:54)";
            _food       = true;
            CurrentTime = DateTime.Now;
        }
    }
}
