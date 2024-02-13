using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData;

public partial class Agency
{
    [Key]
    public int AgencyId { get; set; }

    [Display(Name = "Address")]
    [StringLength(50)]
    public string? AgncyAddress { get; set; }

    [Display(Name = "City")]
    [StringLength(50)]
    public string? AgncyCity { get; set; }

    [Display(Name = "Province")]
    [StringLength(50)]
    public string? AgncyProv { get; set; }

    [Display(Name = "Postal Code")]
    [StringLength(50)]
    public string? AgncyPostal { get; set; }

    [Display(Name = "Country")]
    [StringLength(50)]
    public string? AgncyCountry { get; set; }

    [Display(Name = "Phone")]
    [StringLength(50)]
    public string? AgncyPhone { get; set; }

    [Display(Name = "Fax")]
    [StringLength(50)]
    public string? AgncyFax { get; set; }

    [InverseProperty("Agency")]
    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();
}
