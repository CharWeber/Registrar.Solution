namespace Registrar.Models
{
  public class CourseStudent
  {
    public CourseStudent()
    {
      this.Completed = false;
    }

    public int CourseStudentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public bool Completed { get; set; }
    public virtual Student Student { get; set; }
    public virtual Course Course { get; set; }
  }
}