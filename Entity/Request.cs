using System;
using System.Collections.Generic;

namespace aspnet1.Entity;

public partial class Request
{
    public int Id { get; set; }

    public int ServiceId { get; set; }

    public string Query { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool? Status { get; set; }

    public bool UserNoti { get; set; }

    public bool? AdminNoti { get; set; }
}
