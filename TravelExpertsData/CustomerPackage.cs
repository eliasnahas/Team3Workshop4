using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData;

[Keyless]
[Table("CustomerPackage")]
public partial class CustomerPackage
{
    public int CustomerId { get; set; }

    public int PackageId { get; set; }

    [ForeignKey("CustomerId")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("PackageId")]
    public virtual Package Package { get; set; } = null!;
}
