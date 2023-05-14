using System;
using System.Collections.Generic;

namespace wpfpoprizonok;

public partial class Product
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Articul { get; set; }

    public int? Quantity { get; set; }

    public double? MinPrice { get; set; }
}
