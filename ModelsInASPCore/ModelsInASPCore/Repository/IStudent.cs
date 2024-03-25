using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public interface IStudent
    {
        // Retriving all Students
        List<StudentModel> getAllStudents();
        StudentModel getStudentById(int id);
    }
}
