using CRUDfaculta.DataAccess;
using CRUDfaculta.DataAccess.Entities;
using CRUDfaculta.ViewModels;

/*using CRUDfaculta.ViewModels;*/
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
    }
}
