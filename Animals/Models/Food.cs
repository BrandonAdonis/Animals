using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Food
    {
        public int FoodID { get; set; }

        [Required]
        [Display(Name = "Food Name")]
        [StringLength(50)]
        public string FoodName { get; set; }

        [Required]
        [Display(Name = "Food Type")]
        [StringLength(50)]
        public string FoodType { get; set; }

        [Required]
        [Display(Name = "Num Of Nutrients")]
        [StringLength(50)]
        public string Nutrients { get; set; }

        [Required]
        [Display(Name = "Allergies Ingredients")]
        [StringLength(50)]
        public string AllergiesIngredients { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set; }


        public Animal Animal { get; set; }
    }
}
