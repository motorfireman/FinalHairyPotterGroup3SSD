﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Application.Dto;

public class AddEditUserDto
{
    public string? Id { get; set; }


    [Required(ErrorMessage = "Username required!")]
    [Display(Name = "Username")]
    [RegularExpression(@"^[a-zA-Z0-9\s.,!?_]*$", ErrorMessage = "Only alphanumeric characters, spaces, '.', ',', '!', '?', and '_' are allowed.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "First Name required!")]
    [Display(Name = "First Name")]
    [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only alphabetic characters and spaces are allowed for first name.")]
    public string FirstName { get; set; }


    [Required(ErrorMessage = "Last Name required!")]
    [Display(Name = "Last Name")]
    [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only alphabetic characters and spaces are allowed for last name.")]
    public string LastName { get; set; }


    public string? FullName { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string? Email { get; set; }

    [RegularExpression(@"^\+?[0-9\s\-()]*$", ErrorMessage = "Invalid phone number format.")]
    public string? PhoneNumber { get; set; }


    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }
    public string? ProfilePicturePreview { get; set; }
    public string? ProfilePicture { get; set; }


    [Required]
    public string? Gender { get; set; }
    public bool IsActive { get; set; }
    public bool IsDefaultPassword { get; set; }
    public bool EmailConfirmed { get; set; }


    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    [RegularExpression(@"^[^\s<>]*$", ErrorMessage = "Spaces and '<', '>' characters are not allowed in password.")]
    public string? Password { get; set; }


    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string? ConfirmPassword { get; set; }
}
