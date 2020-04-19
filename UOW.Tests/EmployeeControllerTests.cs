using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UOW.Entities.DTO;
using Xunit;

namespace UOW.Tests
{
    public class EmployeeControllerTests : IClassFixture<TestFixture>
    {
        private readonly HttpClient httpClient;

        public EmployeeControllerTests(TestFixture fixture)
        {
            this.httpClient = fixture.Client;
        }

        [Fact]
        public async Task GetAllEmployees_ValidRequest_ReturnsAllEmployees()
        {
            // Arrange
            EmployeeDTO[] employees = null;
            var requestAddress = "/api/employee";

            // Act
            var response = await httpClient.GetAsync(requestAddress);

            // Assert
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                employees = JsonConvert.DeserializeObject<EmployeeDTO[]>(responseContent);
            }

            Assert.True(employees != null && employees.Count() > 0);
        }

        [Fact]
        public async Task GetEmployeeById_PassValidEmployeeId_ReturnsEmployee()
        {
            // Arrange
            var employeeId = 1;
            EmployeeDTO employee = null;
            var requestAddress = "/api/employee";

            // Act
            var response = await httpClient.GetAsync(requestAddress + "/" + employeeId);

            // Assert
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                employee = JsonConvert.DeserializeObject<EmployeeDTO>(responseContent);
            }

            Assert.True(employee != null);
        }
    }
}
