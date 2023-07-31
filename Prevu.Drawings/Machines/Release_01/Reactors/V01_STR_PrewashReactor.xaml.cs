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
    /// Logica di interazione per V01_STR_PrewashReactor.xaml
    /// </summary>
    public partial class V01_STR_PrewashReactor : UserControl
    {
        public static readonly DependencyProperty ComponentNameProperty =
      DependencyProperty.Register(nameof(ComponentName), typeof(string), typeof(V01_STR_PrewashReactor),
new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.AffectsRender, ComponentNameChangedCallback));

        private static void ComponentNameChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
          => ((V01_STR_PrewashReactor)dependencyObject).Update();

        [Description("Name of the water level component"), Category("_PV")]
        public string ComponentName
        {
            get { return (string)GetValue(ComponentNameProperty); }
            set { SetValue(ComponentNameProperty, value); }
        }

        public static readonly DependencyProperty TrendNameProperty =
          DependencyProperty.Register(nameof(TrendName), typeof(string), typeof(V01_STR_PrewashReactor),
            new FrameworkPropertyMetadata(default(string), FrameworkPropertyMetadataOptions.AffectsRender, TrendNamePropertyChangedCallback));

        private static void TrendNamePropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
          => ((V01_STR_PrewashReactor)dependencyObject).Update();

        [Description("Name of the level trend, percentage only"), Category("_PV")]
        public string TrendName
        {
            get { return (string)GetValue(TrendNameProperty); }
            set { SetValue(TrendNameProperty, value); }
        }
        public V01_STR_PrewashReactor()
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
