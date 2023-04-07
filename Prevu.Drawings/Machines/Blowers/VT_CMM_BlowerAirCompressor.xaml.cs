using Prevu.Drawings.Stores;
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
using System.ComponentModel;

namespace Prevu.Drawings.Machines.Blowers
{
    /// <summary>
    /// Logica di interazione per VT_CMM_BlowerAirCompressor.xaml
    /// </summary>
    public partial class VT_CMM_BlowerAirCompressor : UserControl
    {
        #region Color

        public static readonly DependencyProperty ColorProperty =
        DependencyProperty.Register(nameof(Color), typeof(MaterialColor), typeof(VT_CMM_BlowerAirCompressor),
          new FrameworkPropertyMetadata(MaterialColor.Material, FrameworkPropertyMetadataOptions.AffectsRender, PipeColorChanged));

        private static void PipeColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
          => ((VT_CMM_BlowerAirCompressor)dependencyObject).Update();

        [Description("Color of the Blower/Compressor"), Category("_PV")]
        public MaterialColor Color
        {
            get { return (MaterialColor)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        #endregion

        public VT_CMM_BlowerAirCompressor()
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
            ColorSide.Fill = new SolidColorBrush { Color = Dictionaries.MaterialColors[this.Color] };
        }
    }
}
