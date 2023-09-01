using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDOExtensions.ViewModels;

namespace BDOExtensions
{
    public static class g
    {
        public static Settings Settings { get; set; }

        public static MainWindow MainWindow { get; set; }
        public static MainWindowViewModel MainWindowViewModel { get; set; }
    }
}
