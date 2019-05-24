using System;
using MyCourse.Models.ValueTypes;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MyCourse.Models.Enums;


namespace MyCourse.Models.ViewModels
{

    public class CourseDetailViewModel : CourseViewModel
    {
        public string Description { get; set; }
        public List<LessonViewModel> Lessons { get; set; }

        public TimeSpan TotalCourseDuration
        {
            get => TimeSpan.FromSeconds(Lessons?.Sum(l => l.Duration.TotalSeconds) ?? 0);
        }
    }

}