﻿using Prevu.UIComponents.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Prevu.Drawings.Machines
{
    /// <summary>
    /// Logica di interazione per V01_MU_Grinder.xaml
    /// </summary>
    public partial class V01_MU_Grinder : UserControl
    {
        public static readonly DependencyProperty ComponentNameProperty = DependencyProperty.Register(nameof(ComponentName), typeof(string), typeof(V01_MU_Grinder),
            new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.AffectsRender, ComponentNameChangedCallback));

        private static void ComponentNameChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
          => ((V01_MU_Grinder)dependencyObject).Update();

        [Description("Name of the material level component"), Category("_PV")]
        public string ComponentName
        {
            get { return (string)GetValue(ComponentNameProperty); }
            set { SetValue(ComponentNameProperty, value); }
        }

        public static readonly DependencyProperty TrendNameProperty = DependencyProperty.Register(nameof(TrendName), typeof(string), typeof(V01_MU_Grinder),
            new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.AffectsRender, TrendNamePropertyChangedCallback));

        private static void TrendNamePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
          => ((V01_MU_Grinder)dependencyObject).Update();

        #region Color

        public static readonly DependencyProperty ColorProperty =
          DependencyProperty.Register(nameof(Color), typeof(FillColor), typeof(V01_MU_Grinder),
          new FrameworkPropertyMetadata(FillColor.Water, FrameworkPropertyMetadataOptions.AffectsRender, LevelColorChanged));

        private static void LevelColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        => ((V01_MU_Grinder)dependencyObject).Update();

        [Description("Color of the level"), Category("_PV")]
        public FillColor Color
        {
            get { return (FillColor)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        #endregion

        [Description("Name of the level trend, percentage only"), Category("_PV")]
        public string TrendName
        {
            get { return (string)GetValue(TrendNameProperty); }
            set { SetValue(TrendNameProperty, value); }
        }
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            Update();
        }

        private void Update()
        {
            MaterialLevel.ComponentName = ComponentName;
            MaterialLevel.TrendName = TrendName;
            MaterialLevel.Color = Color;
        }
       
        public V01_MU_Grinder()
        {
            InitializeComponent();
        }
    }
}
