using System.Collections.Generic;
using System.Threading.Tasks;
using Angular_WebApp.Models;

namespace Angular_WebApp.Controllers.Repository
{
    public interface IEmployeeRepo
    {
        Task<Employee> GetEmployeeByIdAsync(int employeeId);
        Task<List<Employee>> GetAllAsync();
        Task PostAsync(Employee model);
        Task PutAsync(Employee model);
        Task DeleteAllAsync();
        Task<Employee> GetEmployeeModel(int id);

    }
}