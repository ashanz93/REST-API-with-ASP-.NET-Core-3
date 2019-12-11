using RESTAPITutorial.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITutorial.Models
{
    [CourseTitleDifferentFromDescriptionAttribute(ErrorMessage = "The title must be diff from the desc")]
    public class CourseForCreationDto //: IValidatableObject
    {
        [Required(ErrorMessage = "Title must be filled")]
        [MaxLength(100, ErrorMessage = "Title should not be more than 100 chars")]
        public string Title { get; set; }

        [MaxLength(500, ErrorMessage = "Description should not be more than 500 chars")]
        public string Description { get; set; }

        /*public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Title.Equals(Description))
            {
                yield return new ValidationResult("The provided description should be diff from the title", new[] { "CourseForCreationDto" });
            }
        }*/
    }
}
