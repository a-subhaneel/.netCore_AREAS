using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebPACS.Areas.Administrator.Models
{
    public class AdministratorModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AdminID { get; set; }

        [Display(Name ="Username")]
        [Required(ErrorMessage = "Please provide a password.")]
        public string AdminName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please provide a password.")]
        public string AdminEmail { get; set; }

        [Required(ErrorMessage = "Please provide a password.")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Must provide fingerprint!")]
        //public string FingerprintImage { get; set; }
    }

}
