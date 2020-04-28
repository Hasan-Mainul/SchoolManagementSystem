using SclManagementSystem.Data.Models;
using System.Collections.Generic;
using System.Text;

namespace SclManagementSystem.Data.Services
{
    public interface IStudentData
    {
        IEnumerable<Student> GetAll();

    }
}
