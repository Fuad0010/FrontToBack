﻿using FronToBack.Models;

namespace FronToBack.ViewModels
{
    public class ProductReturnVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}