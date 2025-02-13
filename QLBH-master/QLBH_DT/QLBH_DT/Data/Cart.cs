using System;
using System.Collections.Generic;

namespace QLBH_DT.Data;

public partial class Cart
{
    public int CartId { get; set; }

    public int UserId { get; set; }

    public int ProductId { get; set; }

    public double Price { get; set; }

    public int Quantity { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
