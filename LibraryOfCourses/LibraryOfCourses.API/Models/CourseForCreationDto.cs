﻿using System.ComponentModel.DataAnnotations;

namespace LibraryOfCourses.API.Models
{

    public class CourseForCreationDto : CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a description.")]
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
