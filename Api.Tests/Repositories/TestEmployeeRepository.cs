using Api.Data;
using Api.Models;
using Faker;

namespace Api.Tests;

public class TestEmployeeRepository : IRepository<Employee>, IDisposable
{
    private List<Employee> employees = new();

    public TestEmployeeRepository()
    {
        employees = DataFaker.FakeEmployees();
    }

    public IEnumerable<Employee> Get()
    {
        return employees;
    }

    public Employee GetById(int id)
    {
        return employees.Find(s => s.EmployeeId == id);
    }

    public Employee Insert(Employee entity)
    {
        employees.Add(entity);
        return entity;
    }

    public void Update(Employee entity)
    {
        Employee selected = employees.FirstOrDefault(s => s.EmployeeId == entity.EmployeeId);
        if (selected != null)
        {
            selected.Name = entity.Name;
        }
    }

    public void Delete(int id)
    {
        employees = employees.Where(s => s.EmployeeId != id).ToList();
    }

    public void Save()
    {
        // Not needed for testing
    }

    #region Dispose
    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing) { }
        }
        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
    }

    #endregion
}
