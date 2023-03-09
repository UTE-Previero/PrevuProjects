using Prevu.Drawings.Stores;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Prevu.Drawings.Machines
{
  /// <summary>
  /// Interaction logic for WaterPump.xaml
  /// </summary>
  public partial class WaterPump : UserControl
  {

    #region Color

    public static readonly DependencyProperty ColorProperty =
    DependencyProperty.Register(nameof(Color), typeof(MaterialColor), typeof(WaterPump),
      new FrameworkPropertyMetadata(MaterialColor.Material, FrameworkPropertyMetadataOptions.AffectsRender, PipeColorChanged));

    private static void PipeColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
      => ((WaterPump)dependencyObject).Update();

    [Description("Color of the pump"), Category("_PV")]
    public MaterialColor Color
    {
      get { return (MaterialColor)GetValue(ColorProperty); }
      set { SetValue(ColorProperty, value); }
    }
    #endregion


    public WaterPump()
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
