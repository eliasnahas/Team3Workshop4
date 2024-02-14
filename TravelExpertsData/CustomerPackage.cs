using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData.Models;

[PrimaryKey("CustomerId", "PackageId")]
[Table("CustomerPackage")]
[Index("PackageId", Name = "IX_CustomerPackage_PackageId")]
public partial class CustomerPackage
{
    [Key]
    public int CustomerId { get; set; }

    [Key]
    public int PackageId { get; set; }
}
