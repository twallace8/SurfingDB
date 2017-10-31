using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurfingMvC.Models
{
    public partial class surf
    {
        public int ID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter an image url")]
        public string Picture { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a surfing location")]
/*      [StringLength(70, ErrorMessage = "Enter between 5 and 40 characters", MinimumLength = 5)]  */
        public string Location { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a continent")]
        /*      [StringLength(25, ErrorMessage = "Please enter between 4 and 25 characters", MinimumLength = 4)] */
        public string Continent { get; set; }

        [Display(Name = "Average Wave Size (ft)")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter an average wave size in feet")] 
        public int Wave_Size { get; set; }

        [Display(Name = "Wave Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the type of wave")]
     /* [StringLength(20, ErrorMessage = "Please enter between 4 and 20 characters", MinimumLength = 4)]  */
        public string Wave_type { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the level of surfing required")]
    /*  [StringLength(20, ErrorMessage = "Please enter between 4 and 20 characters", MinimumLength = 4)] */
        public string Level { get; set; }

        /*[Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a description")] */
        /*  [StringLength(200, ErrorMessage = "Please enter between 4 and 20 characters", MinimumLength = 4)] */
        public string Description { get; set; }   


    }
}