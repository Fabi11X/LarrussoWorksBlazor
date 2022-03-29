using LarrussoWorksBlazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Auth
{
    public interface ILocalStorage
    {
        Task<T> GetValue<T>(ValuesKeys key);

        Task SetValue<T>(ValuesKeys key, T value);

        Task RemoveItem(ValuesKeys key);

        Task ClearAll();
    }
}