using _02_EmployeeAdminPortal.Data;
using _02_EmployeeAdminPortal.Models;
using _02_EmployeeAdminPortal.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _02_EmployeeAdminPortal.Controllers
{
    //localhost:xxxx/api/employees
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDBContext dBContext;

        public EmployeesController(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees = this.dBContext.Employees.ToList();

            return Ok(allEmployees);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetEmployeeById(Guid id)
        {
            var employee = this.dBContext.Employees.Find(id);

            if(employee is null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult updateEmployee(Guid id, AddEmployeeDto updateEmployeeDto)
        {
            var employee = this.dBContext.Employees.Find(id);

            if (employee is null)
            {
                return NotFound($"employee not found with the id: {id}");
            }

            employee.Email = updateEmployeeDto.Email;
            employee.Phone = updateEmployeeDto.Phone;
            employee.Name = updateEmployeeDto.Name;
            employee.Salary = updateEmployeeDto.Salary;

            this.dBContext.SaveChanges();

            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                Email = addEmployeeDto.Email,
                Name = addEmployeeDto.Name,
                Salary = addEmployeeDto.Salary,
                Phone = addEmployeeDto.Phone,
            };

            this.dBContext.Employees.Add(employeeEntity);
            this.dBContext.SaveChanges();

            return Ok(employeeEntity);

        }
    }
}
