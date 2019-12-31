using System.Collections.Generic;
using System.Threading.Tasks;
using UOW.Entities.DTO;

namespace UOW.BAL.Contracts
{
    public interface IEmployeeBAL
    {
        Task<bool> AddNewEmployee(EmployeeDTO employeeDTO);

        Task<EmployeeDTO> GetEmployeeById(int id);

        Task<List<EmployeeDTO>> GetAllEmployees();
    }
}
