﻿using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Prevu.UIComponents.Stores;

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

    #region Color

    public static readonly DependencyProperty ColorProperty =
    DependencyProperty.Register(nameof(Color), typeof(FillColor), typeof(VRC_WaterCollectingTank),
      new FrameworkPropertyMetadata(FillColor.Water, FrameworkPropertyMetadataOptions.AffectsRender, LevelColorChanged));

    private static void LevelColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
    => ((VRC_WaterCollectingTank)dependencyObject).Update();

    [Description("Color of the level"), Category("_PV")]
    public FillColor Color
    {
      get { return (FillColor)GetValue(ColorProperty); }
      set { SetValue(ColorProperty, value); }
    }
    #endregion

    public VRC_WaterCollectingTank()
    {
      InitializeComponent();
    }

    private void Update()
    {
      MaterialLevel.ComponentName = ComponentName;
      MaterialLevel.TrendName = TrendName;
      MaterialLevel.Color = Color;
    }
  }
}
