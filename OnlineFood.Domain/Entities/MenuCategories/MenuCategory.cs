﻿using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.MenuCategories;

public class MenuCategory : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
}

