using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class TblProductMaterial
{
    public int Id { get; set; }

    public string? ProductId { get; set; }

    public string? MaterialId { get; set; }

    public double? Weight { get; set; }

    public virtual TblMaterialCategory? Material { get; set; }

    public virtual TblProduct? Product { get; set; }
}
