using System;
using System.Collections.Generic;

namespace ApiWithDatabase.Models;

public partial class Estudent
{
    public int Id { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentGender { get; set; } = null!;

    public int Standard { get; set; }
}
