using System;
using System.Collections.Generic;

namespace Core.Entities;

public partial class RecipeTable
{
    public int IdRecipe { get; set; }

    public string? NameRecipe { get; set; }

    public string? DescriptionRecipe { get; set; }

    public string? ImgRecipe { get; set; }

    public string? LevelRecipe { get; set; }

    public int? MinuteTimeRecipe { get; set; }

    public int? UnitsRecipe { get; set; }

    public string? InstructionsRecipe { get; set; }

    public int? IdUser { get; set; }
}
