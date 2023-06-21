using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using Prevu.UIComponents.Labels;

namespace Prevu.Drawings.Machines;

/// <summary>
/// Interaction logic for SLX_Silo.xaml
/// </summary>
public partial class SLX_Silo : UserControl
{

  public static readonly DependencyProperty ComponentNameProperty =
DependencyProperty.Register(nameof(ComponentName), typeof(string), typeof(SLX_Silo),
  new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.AffectsRender, ComponentNameChangedCallback));

  private static void ComponentNameChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
    => ((SLX_Silo)dependencyObject).Update();

  [Description("Name of the water level component"), Category("_PV")]
  public string ComponentName
  {
    get { return (string)GetValue(ComponentNameProperty); }
    set { SetValue(ComponentNameProperty, value); }
  }

  public static readonly DependencyProperty TrendNameProperty =
    DependencyProperty.Register(nameof(TrendName), typeof(string), typeof(SLX_Silo),
      new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.AffectsRender, TrendNamePropertyChangedCallback));

  private static void TrendNamePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
    => ((SLX_Silo)dependencyObject).Update();

  [Description("Name of the level trend, percentage only"), Category("_PV")]
  public string TrendName
  {
    get { return (string)GetValue(TrendNameProperty); }
    set { SetValue(TrendNameProperty, value); }
  }

  public SLX_Silo()
  {
    InitializeComponent();
  }

  private void Update()
  {
    WaterLevel.ComponentName = ComponentName;
    WaterLevel.TrendName = TrendName;
  }
}
