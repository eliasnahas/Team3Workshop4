using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData;

public partial class Package
{
    [Key]
    [Display(Name = "Package ID")]
    public int PackageId { get; set; }

    [StringLength(50)]
    [Display(Name = "Name")]
    public string PkgName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    [Display(Name = "Start Date")]
    public DateTime? PkgStartDate { get; set; }

    [Column(TypeName = "datetime")]
    [Display(Name = "End Date")]
    public DateTime? PkgEndDate { get; set; }

    [StringLength(50)]
    [Display(Name = "Description")]
    public string? PkgDesc { get; set; }

    [Column(TypeName = "money")]
    [Display(Name = "Base Price")]
    public decimal PkgBasePrice { get; set; }

    [Column(TypeName = "money")]
    [Display(Name = "Agency Commission")]
    public decimal? PkgAgencyCommission { get; set; }

    [InverseProperty("Package")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [InverseProperty("Package")]
    public virtual ICollection<CustomerPackage> CustomerPackages { get; set; } = new List<CustomerPackage>();

    [InverseProperty("Package")]
    public virtual ICollection<PackagesProductsSupplier> PackagesProductsSuppliers { get; set; } = new List<PackagesProductsSupplier>();


}