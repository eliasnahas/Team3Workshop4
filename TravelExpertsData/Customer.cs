using System;
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

    [Required(ErrorMessage = "Please enter your first name.")]
    [Display(Name = "First Name")]
    [StringLength(25)]
    public string CustFirstName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your last name.")]
    [Display(Name = "Last Name")]
    [StringLength(25)]
    public string CustLastName { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your address.")]
    [Display(Name = "Address")]
    [StringLength(75)]
    public string CustAddress { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your city.")]
    [Display(Name = "City")]
    [StringLength(50)]
    public string CustCity { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your province")]
    [Display(Name = "Province")]
    [StringLength(2, MinimumLength = 2, ErrorMessage = "Province code must be exactly 2 characters.")]
    public string CustProv { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your postal code.")]
    [Display(Name = "Postal Code")]
    [RegularExpression(@"^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$", 
        ErrorMessage = "Please enter a valid postal code: 'A1A 1A1'.")]
    [StringLength(7)]
    public string CustPostal { get; set; } = null!;

    [Required(ErrorMessage = "Please enter your country.")]
    [Display(Name = "Country")]
    [StringLength(25)]
    public string? CustCountry { get; set; }

    
    [RegularExpression(@"^\+?[0-9]*$", ErrorMessage = "Please enter a valid phone number.")]
    [Display(Name = "Home Phone")]
    [StringLength(20)]
    public string? CustHomePhone { get; set; }

    
    [RegularExpression(@"^\+?[0-9]*$", ErrorMessage = "Please enter a valid phone number.")]
    [Display(Name = "Business Phone")]
    [StringLength(20)]
    public string CustBusPhone { get; set; } = null!;

    
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", 
        ErrorMessage = "Please enter a valid email address: 'example@google.com'.")]
    [Display(Name = "Email")]
    [StringLength(50)]
    public string CustEmail { get; set; } = null!;

    public int? AgentId { get; set; }

    [Required(ErrorMessage = "Please enter a username.")]
    [StringLength(30)]
    public string Username { get; set; }

    [Required(ErrorMessage = "Please enter a password.")]
    [StringLength(30, ErrorMessage = "Password must be less than 30 characters.")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Please confirm your password")]
    [Display(Name = "Confirm Password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
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
