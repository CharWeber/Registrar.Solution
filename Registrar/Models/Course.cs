using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.StudentJoinEntities = new HashSet<CourseStudent>();
      this.DepartmentJoinEntities = new HashSet<CourseDepartment>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public virtual ICollection<CourseStudent> StudentJoinEntities { get; set; }
    public virtual ICollection<CourseDepartment> DepartmentJoinEntities { get; set; }
  }
}