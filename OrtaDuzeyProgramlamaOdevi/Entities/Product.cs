﻿using System.ComponentModel.DataAnnotations;

namespace OrtaDuzeyProgramlamaOdevi.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
