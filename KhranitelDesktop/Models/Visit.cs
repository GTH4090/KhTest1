using System;
using System.Collections.Generic;

namespace KhranitelDesktop.Models;

public partial class Visit
{
    public int Id { get; set; }

    public int Userid { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Finishdate { get; set; }

    public DateTime? Finaldate { get; set; }

    public TimeOnly? Finaltime { get; set; }

    public int Typeid { get; set; }

    public int Statusid { get; set; }

    public int Employeeid { get; set; }

    public string? Statusreason { get; set; }

    public int Targetid { get; set; }

    public string? Groupname { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual Target Target { get; set; } = null!;

    public virtual Type Type { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Visitor> Visitors { get; } = new List<Visitor>();
}
