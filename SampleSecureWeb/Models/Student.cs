using System;
using System.ComponentModel.DataAnnotations;

namespace SampleSecureWeb.Models;

public class Student
{
    [Key]
    public String Nim { get; set; } = null!;
    public String FullName { get; set; } = null!;
}   
