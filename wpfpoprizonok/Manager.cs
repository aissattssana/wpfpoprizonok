using System;
using System.Collections.Generic;

namespace wpfpoprizonok;

public partial class Manager
{
    public int ManagerId { get; set; }

    public string ManagerName { get; set; } = null!;

    public string ManagerPasport { get; set; } = null!;

    public string ManagerBirthData { get; set; } = null!;

    public string ManagerBank { get; set; } = null!;

    public string? ManagerFamily { get; set; }

    public string? ManagerHealth { get; set; }

    public string ManagerDegree { get; set; } = null!;

    public string ManagerNfc { get; set; } = null!;
}
