using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using UOW.BAL.Contracts;
using UOW.DAL;
using UOW.DAL.Concretes;
using UOW.Entities.Domain;
using UOW.Entities.DTO;
using UOW.Repositories;

namespace UOW.BAL.Concretes
{
    public class EmployeeBAL : IEmployeeBAL
    {
        private readonly UOWDataContext context;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public EmployeeBAL(UOWDataContext context, IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.context = context;
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AddNewEmployee(AddEmployeeDTO employeeDTO)
        {
            var result = false;

            using (var unitOfWork = new UnitOfWork(context))
            {
                var employee = mapper.Map<Employee>(employeeDTO);
                unitOfWork.Employees.Add(employee);
                result = await unitOfWork.Complete() > 0;
            }

            return result;
        }

        public async Task<List<AddEmployeeDTO>> GetAllEmployees()
        {
            List<AddEmployeeDTO> employees = null;

            var employeesInDb = await employeeRepository.GetAllAsync();

            if (employeesInDb != null)
            {
                employees = mapper.Map<List<AddEmployeeDTO>>(employeesInDb);
            }

            return employees;
        }

        public async Task<AddEmployeeDTO> GetEmployeeById(int id)
        {
            AddEmployeeDTO employee = null;

            var employeeInDb = await employeeRepository.GetByIdAsync(id);

            if (employeeInDb != null)
            {
                employee = mapper.Map<AddEmployeeDTO>(employeeInDb);
            }

            return employee;
        }
    }
}
