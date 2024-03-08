using OneToOne1.db;
using OneToOne1.Models;

namespace OneToOne1
{
    public class Program
    {
        static void Main(string[] args)
        {
            OneToOne1DbContext _dbContext = new OneToOne1DbContext();

            TestStudent stud1 = new TestStudent();
            stud1.Name = "TestMon";
            stud1.Description = "Description";

            stud1.StudentAdressObj = new StudentAdress()
            { 
                City = "cityName",
                Pin=680563,
            };


            _dbContext.TestStudents.Add(stud1);
            _dbContext.SaveChanges();
        }
    }
}
