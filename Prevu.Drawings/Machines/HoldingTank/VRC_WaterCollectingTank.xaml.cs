using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prevu.Drawings.Machines
{
  /// <summary>
  /// Interaction logic for VRC_WaterCollectingTank.xaml
  /// </summary>
  public partial class VRC_WaterCollectingTank : UserControl
  {
    public static readonly DependencyProperty ComponentNameProperty =
      DependencyProperty.Register(nameof(ComponentName), typeof(string), typeof(VRC_WaterCollectingTank),
new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.AffectsRender, ComponentNameChangedCallback));

    private static void ComponentNameChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
      => ((VRC_WaterCollectingTank)dependencyObject).Update();

    [Description("Name of the water level component"), Category("_PV")]
    public string ComponentName
    {
      get { return (string)GetValue(ComponentNameProperty); }
      set { SetValue(ComponentNameProperty, value); }
    }

    public static readonly DependencyProperty TrendNameProperty =
      DependencyProperty.Register(nameof(TrendName), typeof(string), typeof(VRC_WaterCollectingTank),
        new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.AffectsRender, TrendNamePropertyChangedCallback));

    private static void TrendNamePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
      => ((VRC_WaterCollectingTank)dependencyObject).Update();

    [Description("Name of the level trend, percentage only"), Category("_PV")]
    public string TrendName
    {
      get { return (string)GetValue(TrendNameProperty); }
      set { SetValue(TrendNameProperty, value); }
    }

    public VRC_WaterCollectingTank()
    {
      InitializeComponent();
    }

    private void Update()
    {
      WaterLevel.ComponentName = ComponentName;
      WaterLevel.TrendName = TrendName;
    }
  }
}
