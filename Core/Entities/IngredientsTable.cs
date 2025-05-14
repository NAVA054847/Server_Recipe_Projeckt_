using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class IngredientsTable
{
    public int IdIngredients { get; set; }

    public string? NameIngredients { get; set; }

    public virtual ICollection<IngredientsrecipeTable> IngredientsrecipeTables { get; set; } = new List<IngredientsrecipeTable>();
}
