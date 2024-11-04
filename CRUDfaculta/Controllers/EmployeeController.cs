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

        public EmployeeViewModel? FindEmployeeById(int employeeId)
        {
            var employee = dbContext.Employees.Find(employeeId);

            if (employee == null)
                return null;

            EmployeeViewModel result = new EmployeeViewModel
            {
                EmployeeId = employee.EmployeeId,
                FullName = employee.FullName,
                Department = employee.Department,
                BirthDate = employee.BirthDate,
                Age = employee.Age,
                PhoneNumber = employee.PhoneNumber,
            };
            return result;
        }
      
        public bool EditEmployee(EmployeeViewModel model)
        {
            try
            {
                var employee = dbContext.Employees.Find(model.EmployeeId);
                if (employee == null) return false;

                employee.FullName = model.FullName;
                employee.Department = model.Department;
                employee.BirthDate = model.BirthDate;
                employee.Age = model.Age;
                employee.PhoneNumber = model.PhoneNumber;

                dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
         
        }

        public bool DeleteEmployee(int Id)
        {
            try
            {
                var employee = dbContext.Employees.Find(Id);
                if (employee == null) return false;
                dbContext.Employees.Remove(employee);
                dbContext.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
           
        }
    }
}
