﻿namespace Blazor.Todo.Shared.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string CategoryName { get; set; } = string.Empty;
    }
}
