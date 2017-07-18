using Common.CustomFilters;
using Model.Auth;
using Model.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class CourseLessonLearnedsPerStudents : AuditEntity, ISoftDeleted
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

        //Relaciones
        public LessonsPerCourse Lesson { get; set; }
        public int LessonId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser  User { get; set; }
        public string UserId { get; set; }

    }
}
