using System.Data.Entity;

namespace TestNinja.Mocking
{
    public class EmployeeController
    {
        private readonly IEmployeeStorage _storage;
        public EmployeeController(IEmployeeStorage storage)
        {
            _storage = storage;
        }

        public ActionResult DeleteEmployee(int id)
        {
            _storage.DeleteEmployee(id);
            return RedirectToAction("Employees");
        }

        private ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }
 
    public class RedirectResult : ActionResult { }

    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class Employee
    {
    }

    public interface IEmployeeStorage
    {
        void DeleteEmployee(int id);
    }

    public class EmployeeStorage : IEmployeeStorage
    {
        private EmployeeContext _db;

        public EmployeeStorage()
        {
            _db = new EmployeeContext();
        }

        public void DeleteEmployee(int id)
        {
            var employee = _db.Employees.Find(id);
            if (_db.Employees == null) return;
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }
    }

    //My Solution
    #region
    //public class EmployeeController
    //{
    //    private readonly IEmployeeStorage _employeeStorage;
    //    //private EmployeeContext _db;

    //    public EmployeeController(IEmployeeStorage employeeStorage)
    //    {
    //        //_db = new EmployeeContext();
    //        _employeeStorage = employeeStorage;
    //    }

    //    public ActionResult DeleteEmployee(int id)
    //    {
    //        //var employee = _db.Employees.Find(id);
    //        //_db.Employees.Remove(employee);
    //        //_db.SaveChanges();
    //        var result = _employeeStorage.Dispose(id);
    //        return RedirectToAction("Employees");
    //    }

    //    private ActionResult RedirectToAction(string employees)
    //    {
    //        return new RedirectResult();
    //    }
    //}

    //public class ActionResult { }

    //public class RedirectResult : ActionResult { }

    //public interface IEmployeeContext
    //{
    //    DbSet<Employee> Employees { get; set; }

    //    string SaveChanges();
    //}

    //public class EmployeeContext : IEmployeeContext
    //{
    //    public DbSet<Employee> Employees { get; set; }

    //    public string SaveChanges()
    //    {
    //        return "Employee deleted";
    //    }
    //}

    //public class Employee
    //{
    //}

    //public interface IEmployeeStorage
    //{
    //    DbSet<Employee> Employees { get; set; }

    //    string Dispose(int id);
    //    string SaveChanges();
    //}

    //public class EmployeeStorage : IEmployeeContext, IEmployeeStorage
    //{
    //    public DbSet<Employee> Employees { get; set; }

    //    public string SaveChanges()
    //    {
    //        return "Employee deleted";
    //    }

    //    public string Dispose(int id)
    //    {
    //        var employee = Employees.Find(id);
    //        Employees.Remove(employee);

    //        return SaveChanges();
    //    }

    //}
    #endregion
}