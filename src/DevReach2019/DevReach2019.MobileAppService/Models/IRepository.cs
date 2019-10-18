using System.Collections.Generic;

namespace DevReach2019.MobileAppService.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();

        T Get(string id);
    }
}
