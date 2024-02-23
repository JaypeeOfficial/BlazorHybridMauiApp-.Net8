using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClassLibrary.Domain.Entities;
   public class User : BaseEntity
    {
    public string FullName { get; set; } = string.Empty;

    [Column(TypeName = "Date")]
    public DateTime? DateOfBirth { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;


    [Column(TypeName = "Date")]
    public DateTime DateAdded { get; set; } = DateTime.Now;
    public string AddedBy { get; set; } = string.Empty;
}

