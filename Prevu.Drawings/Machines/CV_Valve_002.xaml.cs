using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using System.Windows;

using Prevu.Drawings.Stores;

namespace Prevu.Drawings.Machines
{
  /// <summary>
  /// Interaction logic for CV_Valve.xaml
  /// </summary>
  public partial class CV_Valve_002 : UserControl
  {
    #region Color

    public static readonly DependencyProperty ColorProperty =
    DependencyProperty.Register(nameof(Color), typeof(MaterialColor), typeof(CV_Valve_002),
      new FrameworkPropertyMetadata(MaterialColor.None, FrameworkPropertyMetadataOptions.AffectsRender, PipeColorChanged));

    private static void PipeColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
      => ((CV_Valve_002)dependencyObject).Update();

    [Description("Color of the utility"), Category("_PV")]

    public MaterialColor Color
    {
      get { return (MaterialColor)GetValue(ColorProperty); }
      set { SetValue(ColorProperty, value); }
    }
    #endregion
    
    public CV_Valve_002()
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
