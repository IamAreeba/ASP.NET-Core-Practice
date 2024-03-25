using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            // x is representing our Model
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }

        // Making our own data source
        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel { rollNo = 1, Name = "Areeba", Gender = "Female", Standard = "Final Year"},
                new StudentModel { rollNo = 2, Name = "Aiman", Gender = "Female", Standard = "Second Year"},
                new StudentModel { rollNo = 3, Name = "Ali", Gender = "Male", Standard = "Matric"},
                new StudentModel { rollNo = 4, Name = "Amjad", Gender = "Male", Standard = "Office"},
                new StudentModel { rollNo = 5, Name = "Shaheryar", Gender = "Male", Standard = "Second Year"},
                new StudentModel { rollNo = 6, Name = "Haseeb", Gender = "Male", Standard = "4th Class"}
            };
        }
    }
}
