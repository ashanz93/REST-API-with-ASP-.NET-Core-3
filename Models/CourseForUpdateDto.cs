using RESTAPITutorial.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITutorial.Models
{
    public class CourseForUpdateDto : CourseForManipulationDto
    {
        [Required(ErrorMessage = "Fill out the description")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
