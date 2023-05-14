using System;
using System.Collections.Generic;

namespace wpfpoprizonok;

public partial class Material
{
    public int MaterialId { get; set; }

    public string MaterialName { get; set; } = null!;

    public int MaterialMinCont { get; set; }

    public string MaterialDescription { get; set; } = null!;

    public string? MaterialPhoto { get; set; }

    public int MaterialCost { get; set; }

    public string MaterialType { get; set; } = null!;
}
