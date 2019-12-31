using System.Collections.Generic;
using System.Threading.Tasks;
using UOW.Entities.DTO;

namespace UOW.BAL.Contracts
{
    public interface IEmployeeBAL
    {
        Task<bool> AddNewEmployee(AddEmployeeDTO employeeDTO);

        Task<AddEmployeeDTO> GetEmployeeById(int id);

        Task<List<AddEmployeeDTO>> GetAllEmployees();
    }
}
