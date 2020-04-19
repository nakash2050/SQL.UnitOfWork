using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UOW.BAL.Contracts;
using UOW.Entities.DTO;

namespace UOW.API.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBAL employeeBAL;

        public EmployeeController(IEmployeeBAL employeeBAL)
        {
            this.employeeBAL = employeeBAL;
        }

        [HttpPost]
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddNewEmployee(AddEmployeeDTO employeeDTO)
        {
            var response = await employeeBAL.AddNewEmployee(employeeDTO);
            return Ok(response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<AddEmployeeDTO>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllEmployees()
        {
            var response = await employeeBAL.GetAllEmployees();
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(AddEmployeeDTO), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var response = await employeeBAL.GetEmployeeById(id);
            return Ok(response);
        }
    }
}
