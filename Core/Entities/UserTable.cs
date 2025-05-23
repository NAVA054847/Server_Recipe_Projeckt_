﻿using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class UserTable
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Lastname { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<RecipeTable> RecipeTables { get; set; } = new List<RecipeTable>();
}
