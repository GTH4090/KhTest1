using System;
using System.Collections.Generic;

namespace KhranitelDesktop.Models;

public partial class Visitor
{
    public int Id { get; set; }

    public int Visitid { get; set; }

    public byte[]? Photo { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime Birthdate { get; set; }

    public string Passportserial { get; set; } = null!;

    public string Passportnumber { get; set; } = null!;

    public byte[] Docsscan { get; set; } = null!;

    public string? Comment { get; set; }

    public string? Organisation { get; set; }

    public bool Isbanned { get; set; }

    public virtual Visit Visit { get; set; } = null!;
}
