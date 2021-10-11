using System.Collections.Generic;
using System;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.CourseJoinEntities = new HashSet<CourseStudent>();
      this.DepartmentJoinEntities = new HashSet<DepartmentStudent>();
    }

    public int StudentId {get;set;}
    public string Name {get;set;}
    public DateTime EnrollDate {get;set;}
    public virtual ICollection <CourseStudent> CourseJoinEntities {get;set;}
    public virtual ICollection <DepartmentStudent> DepartmentJoinEntities {get;set;}
  }
}