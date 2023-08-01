using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
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
using Prevu.Drawings.Stores;

namespace Prevu.Drawings.Machines
{
    /// <summary>
    /// Logica di interazione per V01_CV_Valve_wColor.xaml
    /// </summary>
    public partial class V01_CV_Valve_wColor : UserControl
    {
        #region Color

        public static readonly DependencyProperty ColorProperty =
        DependencyProperty.Register(nameof(Color), typeof(MaterialColor), typeof(V01_CV_Valve_wColor),
          new FrameworkPropertyMetadata(MaterialColor.None, FrameworkPropertyMetadataOptions.AffectsRender, PipeColorChanged));

        private static void PipeColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
          => ((V01_CV_Valve_wColor)dependencyObject).Update();

        [Description("Color of the utility"), Category("_PV")]

        public MaterialColor Color
        {
            get { return (MaterialColor)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        #endregion
        public V01_CV_Valve_wColor()
        {
            InitializeComponent();
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            Update();
        }

        private void Update()
        {
            //ColorSide.Visibility = (Color == MaterialColor.None) ? Visibility.Visible : Visibility.Hidden;
            ColorSide.Fill = new SolidColorBrush { Color = Dictionaries.MaterialColors[this.Color] };
            ColorSide.Stroke = new SolidColorBrush { Color = Dictionaries.MaterialColors[this.Color] };
        }
    }
}
