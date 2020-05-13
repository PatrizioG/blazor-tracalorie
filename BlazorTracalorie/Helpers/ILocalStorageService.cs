using BlazorTracalorie.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTracalorie.Helpers
{
    public interface ILocalStorageService
    {
        Task<ICollection<Meal>> GetMealsFromStorage();
        Task UpdateMealStorage(ICollection<Meal> meals);
    }
}