using System;
using System.Collections.Generic;

namespace KhranitelDesktop.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public int? Departmentid { get; set; }

    public int? Divisionid { get; set; }

    public string Code { get; set; } = null!;

    public virtual Department? Department { get; set; }

    public virtual Division? Division { get; set; }

    public virtual ICollection<Visit> Visits { get; } = new List<Visit>();
}
