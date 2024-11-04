using CRUDfaculta.DataAccess;
using CRUDfaculta.DataAccess.Entities;
using CRUDfaculta.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace CRUDfaculta.Controllers
{
    public class EmployeeController
    {
        private readonly AppDBContext dbContext;
        public EmployeeController(AppDBContext dBContext)
        {
            this.dbContext = dBContext;
        }
        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            return await dbContext.Employees.OrderBy(x => x.FullName).Select(x => new EmployeeViewModel
            {
                EmployeeId = x.EmployeeId,
                FullName = x.FullName,
                Department = x.Department,
                BirthDate = x.BirthDate,
                Age = x.Age,
                PhoneNumber = x.PhoneNumber,
            }).ToListAsync();
        }


        public bool CreateNewEmployee(EmployeeViewModel employeeModel)
        {
            try
            {
                Employee employee = new Employee()
                {

                    FullName = employeeModel.FullName,
                    Department = employeeModel.Department,
                    BirthDate = employeeModel.BirthDate,
                    Age = employeeModel.Age,
                    PhoneNumber = employeeModel.PhoneNumber,
                };
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


       /* //add employee
        public async Task<Employee> AddEmployee(EmployeeViewModel employeeModel)
        {
            var employee = new Employee
            {
                EmployeeId = employeeModel.EmployeeId,
                FullName = employeeModel.FullName,
                Department = employeeModel.Department,
                BirthDate = employeeModel.BirthDate,
                Age = employeeModel.Age,
                PhoneNumber = employeeModel.PhoneNumber
            };
            dbContext.Employees.Add(employee);
            await dbContext.SaveChangesAsync();
            return employee;
        }
        //delete employee
        public async Task<bool> DeleteEmployee(int employeeId)
        {
            var employee = await dbContext.Employees.FindAsync(employeeId);
            if(employee == null) 
                return false;
            dbContext.Employees.Remove(employee);
            await dbContext.SaveChangesAsync();
            return true;
        }*/


    }
}
