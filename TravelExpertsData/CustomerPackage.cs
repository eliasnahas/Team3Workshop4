using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData;

[Table("CustomerPackage")]
public partial class CustomerPackage
{
    [Key]
    public int CustomerPackageId { get; set; }

    public int CustomerId { get; set; }

    public int PackageId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("CustomerPackages")]
    public virtual Customer Customer { get; set; } = null!;

    [ForeignKey("PackageId")]
    [InverseProperty("CustomerPackages")]
    public virtual Package Package { get; set; } = null!;
}
