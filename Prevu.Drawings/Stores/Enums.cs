using System;
using System.Collections.Generic;
using System.Text;

namespace Prevu.Drawings.Stores
{
  public enum PipeHeight
  {
    Small = 5,
    Medium = 10,
    Big = 20
  }

  public enum MaterialColor
  {
    Material,
    Water,
    Air,
    Steam,
    ByProduct
  }

  public enum PipeIconKind
  {
    None,
    Right,
    Left,
    Up,
    Down,
    Waste,
    Air
  }
}
