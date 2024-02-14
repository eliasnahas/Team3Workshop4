﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TravelExpertsData;

[Index("AgentId", Name = "EmployeesCustomers")]
public partial class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [Required(ErrorMessage ="Please Enter a First Name")] 
    [StringLength(25)]
    public string CustFirstName { get; set; } = null!;
    [Required(ErrorMessage = "Please Enter a Last Name")]
    [StringLength(25)]
    public string CustLastName { get; set; } = null!;
    [Required(ErrorMessage = "Please Enter a Address")]
    [StringLength(75)]
    public string CustAddress { get; set; } = null!;
    [Required(ErrorMessage = "Please Enter a City")]
    [StringLength(50)]
    public string CustCity { get; set; } = null!;
    [Required(ErrorMessage = "Please Enter a Province")]
    [StringLength(2)]
    public string CustProv { get; set; } = null!;
    [Required(ErrorMessage = "Please Enter a Postal Code")]
    [StringLength(7)]
    public string CustPostal { get; set; } = null!;

    [StringLength(25)]
    public string? CustCountry { get; set; }

    [StringLength(20)]
    public string? CustHomePhone { get; set; }
    [Required(ErrorMessage = "Please Enter a Business Phone")]
    [StringLength(20)]
    public string CustBusPhone { get; set; } = null!;

    [StringLength(50)]
    public string? CustEmail { get; set; } = null!;

    public int? AgentId { get; set; }

    [Required(ErrorMessage = "Please enter a username.")]
    [StringLength(30)]
    public string Username { get; set; }

    [Required(ErrorMessage = "Please enter a password.")]
    [StringLength(30)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Please confirm your password")]
    [Display(Name = "Confirm Password")]
    [Compare("Password")]
    [NotMapped]
    public string ConfirmPassword { get; set; }

    [ForeignKey("AgentId")]
    [InverseProperty("Customers")]
    public virtual Agent? Agent { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [InverseProperty("Customer")]
    public virtual ICollection<CreditCard> CreditCards { get; set; } = new List<CreditCard>();

    [InverseProperty("Customer")]
    public virtual ICollection<CustomersReward> CustomersRewards { get; set; } = new List<CustomersReward>();
}
