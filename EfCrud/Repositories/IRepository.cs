using EfCrud.Models;

namespace EfCrud.Repositories
{
    public interface IRepository<T>
    {
       public  void AddRecord(T emp);
        public IEnumerable<T> GetAllRecords();
        public T GetSingleRecord(int id);
       public  T EditRecord(int id);
       public T DeleteRecord(int id);


    }
}
