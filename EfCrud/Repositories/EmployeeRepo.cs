using EfCrud.Models;

namespace EfCrud.Repositories
{
    public class EmployeeRepo:IRepository<Employee> 
    {
        EmployeeDbContext _context;
        public EmployeeRepo(EmployeeDbContext context)
        {
            _context = context;
        }
        void AddRecord(Employee emp)
        {
            _context.Employees.Add(emp);
        }
        public IEnumerable<Employee> GetAllRecords()
        {
            return 0;
        }
         public Employee GetSingleRecord(int id)
        {
            return 0;
        }
    }
        public Employee EditRecord(int id)
        {
        return 0;
    }
}
        public Employee DeleteRecord(int id)
        {
             return 0;
}
        }
    }
}
