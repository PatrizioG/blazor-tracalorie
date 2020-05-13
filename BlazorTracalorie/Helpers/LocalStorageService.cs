using BlazorTracalorie.Model;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorTracalorie.Helpers
{
    public class LocalStorageService : ILocalStorageService
    {
        private readonly IJSRuntime _jsRuntime;

        public LocalStorageService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public async Task<ICollection<Meal>> GetMealsFromStorage()
        {
            var json = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "items");
            var result = JsonSerializer.Deserialize<ICollection<Meal>>(json);

            return result ?? new List<Meal>();
        }

        public async Task UpdateMealStorage(ICollection<Meal> meals)
        {
            await _jsRuntime.InvokeAsync<ICollection<Meal>>("localStorage.setItem", "items", JsonSerializer.Serialize(meals));
        }
    }
}
