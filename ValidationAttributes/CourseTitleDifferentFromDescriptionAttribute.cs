using RESTAPITutorial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPITutorial.ValidationAttributes
{
    public class CourseTitleDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var course = (CourseForCreationDto)validationContext.ObjectInstance;

            if (course.Title.Equals(course.Description))
            {
                return new ValidationResult(ErrorMessage, new[] { nameof(CourseForCreationDto) });
            }

            return ValidationResult.Success;
        }
    }
}
