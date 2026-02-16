using System;

namespace mvctest.Models;

public class Staff
{
    public int StaffId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string? Bio { get; set; }
    public bool Admin { get; set; }
    public int Age { get; set; }
}
