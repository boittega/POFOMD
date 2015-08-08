using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace POFOMD.Models
{
    public class CommentViewModel
    {
        [Key]
        public int CommentID { get; set; }

        [Required]
        [Display(Name="Nome")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Comentário")]
        [DataType(DataType.MultilineText)]
        public string Commentary { get; set; }
    }
}