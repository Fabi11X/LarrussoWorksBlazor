using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using LarrussoWorksBlazor.Auth;
using LarrussoWorksBlazor.Helpers;

namespace LarrussoWorksBlazor.Data
{
    public class LocalStorage : ILocalStorage
    {
        public LocalStorage(IJSRuntime jsRuntime)
        {
            this.JSRuntime = jsRuntime;
        }
        private readonly IJSRuntime JSRuntime;

        private readonly string tipoDeAlmacenamiento = "sessionStorage.";
        public async Task ClearAll()
        {
            await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}clear").ConfigureAwait(false);
        }

        public async Task<T> GetValue<T>(ValuesKeys key)
        {
            string data = await JSRuntime.InvokeAsync<string>($"{tipoDeAlmacenamiento}getItem", key.ToString()).ConfigureAwait(false);
            return IsDataNull.Check<T>(data);
        }

        public async Task RemoveItem(ValuesKeys key)
        {
            await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}removeItem", key.ToString()).ConfigureAwait(false);
        }

        public async Task SetValue<T>(ValuesKeys key, T value)
        {
            await JSRuntime.InvokeVoidAsync($"{tipoDeAlmacenamiento}setItem", key.ToString(), JsonSerializer.Serialize(value)).ConfigureAwait(false);
        }
    }
}
