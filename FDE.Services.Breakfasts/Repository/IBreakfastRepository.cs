using System;
using System.Collections.Generic;
using System.Text;

namespace FDE.Services.Breakfasts.Repository
{
    public interface IBreakfastRepository
    {
        List<string> GetBreaskfasts();

        string GetBreakfastById(int id);

        string AddBreakfast(string value);

        string UpdateBreakfast(int id, string value);

        string DeleteBreakfast(int id);
    }
}
