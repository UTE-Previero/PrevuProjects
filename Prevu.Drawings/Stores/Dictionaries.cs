using MaterialDesignColors.Recommended;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace Prevu.Drawings.Stores
{
  public static class Dictionaries
  {
    public static IDictionary<MaterialColor, Color> MaterialColors { get; } = new Dictionary<MaterialColor, Color>
    {
      {MaterialColor.Material,  BlueSwatch.BlueA400 },
      {MaterialColor.Water,     CyanSwatch.CyanA200 },
      {MaterialColor.Air,       AmberSwatch.AmberA400 },
      {MaterialColor.ByProduct, BrownSwatch.Brown500 }
    };

    public static IDictionary<PipeIconKind, PackIconKind> PipeIcons { get; } = new Dictionary<PipeIconKind, PackIconKind>
    {
      {PipeIconKind.Right, PackIconKind.ChevronRight },
      {PipeIconKind.Left, PackIconKind.ChevronLeft },
      {PipeIconKind.Up, PackIconKind.ChevronUp },
      {PipeIconKind.Down, PackIconKind.ChevronDown },
      {PipeIconKind.Waste, PackIconKind.TrashOutline },
      {PipeIconKind.Air, PackIconKind.WeatherWindy }
    };
  }
}
