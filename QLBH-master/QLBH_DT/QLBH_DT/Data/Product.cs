using System;
using System.Collections.Generic;

namespace QLBH_DT.Data;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int? CategoryId { get; set; }

    public double Price { get; set; }

    public double Discount { get; set; }

    public int Quantity { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual Category? Category { get; set; }
}
