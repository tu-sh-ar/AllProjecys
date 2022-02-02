
namespace OneToOne_Relation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            SchoolContext context = new SchoolContext();
            student.StudentName = "Tushar";
            context.Student.Add(student); 
        }
    }
}