using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData;

public partial class Agent
{
    [Key]
    public int AgentId { get; set; }

    [Display(Name = "Name")]
    [StringLength(20)]
    public string? AgtFirstName { get; set; }

    [Display(Name = "Middle Initial")]
    [StringLength(5)]
    public string? AgtMiddleInitial { get; set; }

    [Display(Name = "Last Name")]
    [StringLength(20)]
    public string? AgtLastName { get; set; }

    [Display(Name = "Phone")]
    [StringLength(20)]
    public string? AgtBusPhone { get; set; }

    [Display(Name = "Email")]
    [StringLength(50)]
    public string? AgtEmail { get; set; }

    [Display(Name = "Position")]
    [StringLength(20)]
    public string? AgtPosition { get; set; }

    [Display(Name = "Agency")]
    public int? AgencyId { get; set; }

    [ForeignKey("AgencyId")]
    [InverseProperty("Agents")]
    public virtual Agency? Agency { get; set; }

    [InverseProperty("Agent")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
