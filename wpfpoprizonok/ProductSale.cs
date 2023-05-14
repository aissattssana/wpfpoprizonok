using System;
using System.Collections.Generic;

namespace wpfpoprizonok;

public partial class ProductSale
{
    public int ProductSaleId { get; set; }

    public string ProductName { get; set; } = null!;

    public string AgentName { get; set; } = null!;

    public DateTime Date { get; set; }

    public int Count { get; set; }
}
