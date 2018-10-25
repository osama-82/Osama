using System;
using System.Collections.Generic;

namespace WebApi.Model
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime? IntroductionDate { get; set; }
        public decimal? Price { get; set; }
        public string Url { get; set; }
        public int? CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
