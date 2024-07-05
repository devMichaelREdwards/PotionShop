﻿using System;
using System.Collections.Generic;

namespace Api.Models;

public partial class Ingredient
{
    public int IngredientId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public int? EffectId { get; set; }

    public int? IngredientCategoryId { get; set; }

    public int? ProductId { get; set; }

    public virtual Effect? Effect { get; set; }

    public virtual IngredientCategory? IngredientCategory { get; set; }

    public virtual ICollection<OrderIngredient> OrderIngredients { get; set; } = new List<OrderIngredient>();

    public virtual Product? Product { get; set; }
}
