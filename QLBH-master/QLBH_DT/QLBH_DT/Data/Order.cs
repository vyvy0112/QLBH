using System;
using System.Collections.Generic;

namespace QLBH_DT.Data;

public partial class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public double Price { get; set; }

    public decimal TotalPrice { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual User User { get; set; } = null!;
}
