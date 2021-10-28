using System.Collections.Generic;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class AllExercisesVM
    {
        public List<ExerciseVM> Exercises { get; set; }
        public PaginatorVM PaginatorVM { get; set; }
    }
}
