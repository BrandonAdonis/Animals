using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }


        [Required]
        [Display(Name = "Animal Name")]
        [StringLength(50)]
        public string AnimalName { get; set; }


        [Required]
        [Display(Name = "Habitat")]
        [StringLength(50)]
        public string Habitat { get; set; }


        [Required]
        [Display(Name = "Type Species")]
        [StringLength(50)]
        public string Category { get; set; }


        [Required]
        [Display(Name = "Animals Age")]
        [StringLength(50)]
        public string AgeOfAnimal { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Registered")]
        public DateTime DateRegistered { get; set; }


        [Required]
        [Display(Name = "Feeding Time")]
        [DataType(DataType.Time)]
        public DateTime FeedingTime { get; set; }


        [Required]
        [Display(Name = "Animal Checkup")]
        [DataType(DataType.Time)]
        public DateTime AnimalCheckup { get; set; }

        public ICollection<StaffMember> StaffMember { get; set; }
    }
}
