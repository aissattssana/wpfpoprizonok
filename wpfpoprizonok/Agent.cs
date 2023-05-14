using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace wpfpoprizonok;

public partial class Agent
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Logo { get; set; }

    public string? AgentIndex { get; set; }

    public string? Region { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? HouseNumber { get; set; }

    public int? Prioritet { get; set; }

    public string? Director { get; set; }

    public string? Inn { get; set; }

    public string? Kpp { get; set; }

    [NotMapped]
    public string PhotoPath => "Resource/" + Logo;
}
