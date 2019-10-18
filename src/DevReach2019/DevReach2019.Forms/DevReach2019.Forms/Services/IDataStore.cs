using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevReach2019.Forms.Services
{
    public interface IDataStore<T>
    {
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);

        Task<T> GetItemAsync(string id);

        bool IsLoaded { get; set; }
    }
}
