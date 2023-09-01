using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDOExtensions.ViewModels;
using ReactiveUI;

namespace BDOExtensions
{
    public class Settings : ViewModelBase
    {
        #region Overlay Settings

        private bool _drawAlch;
        public bool DrawAlch
        {
            get => _drawAlch;
            set => this.RaiseAndSetIfChanged(ref _drawAlch, value);
        }

        private bool _drawFood;
        public bool DrawFood
        {
            get => _drawFood;
            set => this.RaiseAndSetIfChanged(ref _drawFood, value);
        }

        private bool _drawStone;
        public bool DrawStone
        {
            get => _drawStone;
            set => this.RaiseAndSetIfChanged(ref _drawStone, value);
        }

        private bool _drawShelter;
        public bool DrawShelter
        {
            get => _drawShelter;
            set => this.RaiseAndSetIfChanged(ref _drawShelter, value);
        }

        private bool _drawBalm;
        public bool DrawBalm
        {
            get => _drawBalm;
            set => this.RaiseAndSetIfChanged(ref _drawBalm, value);
        }

        private bool _alertLuck;
        public bool AlertLuck
        {
            get => _alertLuck;
            set => this.RaiseAndSetIfChanged(ref _alertLuck, value);
        }

        private bool _drawOverlayWhenNotActive;
        public bool DrawOverlayWhenNotActive
        {
            get => _drawOverlayWhenNotActive;
            set => this.RaiseAndSetIfChanged(ref _drawOverlayWhenNotActive, value);
        }

        private bool _overlayOpacity;
        public bool OverlayOpacity
        {
            get => _overlayOpacity;
            set => this.RaiseAndSetIfChanged(ref _overlayOpacity, value);
        }

        private bool _overlayOpacityWhenNotActive;
        public bool OverlayOpacityWhenNotActive
        {
            get => _overlayOpacityWhenNotActive;
            set => this.RaiseAndSetIfChanged(ref _overlayOpacityWhenNotActive, value);
        }
        #endregion
    }
}
