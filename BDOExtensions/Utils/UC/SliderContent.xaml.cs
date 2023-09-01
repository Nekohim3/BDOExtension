using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BDOExtensions.Utils.UC
{
    /// <summary>
    /// Interaction logic for SliderContent.xaml
    /// </summary>
    public partial class SliderContent : UserControl
    {
        public SliderContent()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(SliderContent));

        public string Text
        {
            get => GetValue(TextProperty).ToString();
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty MinimumProperty = DependencyProperty.Register(
                                                        "Minimum", typeof(double), typeof(SliderContent), new PropertyMetadata(default(double)));

        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty = DependencyProperty.Register(
                                                        "Maximum", typeof(double), typeof(SliderContent), new PropertyMetadata(default(double)));

        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
                                                        "Value", typeof(double), typeof(SliderContent), new PropertyMetadata(default(double)));

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty TickFrequencyProperty = DependencyProperty.Register(
                                                        "TickFrequency", typeof(double), typeof(SliderContent), new PropertyMetadata(default(double)));

        public double TickFrequency
        {
            get { return (double)GetValue(TickFrequencyProperty); }
            set { SetValue(TickFrequencyProperty, value); }
        }
    }
}
