using FDE.Infrastructure.Messages.Breakfast;
using System.Collections.Generic;

namespace FDE.Services.Breakfasts
{
    public interface IBreakfastService
    {
        GetBreakfastByIdResponse GetBreakfastById(GetBreakfastByIdRequest request);

        AddBreakfastResponse AddBreakfast(AddBreakfastRequest request);

        DeleteBreakfastResponse DeleteBreakfast(DeleteBreakfastRequest request);

        UpdateBreakfastResponse UpdateBreakfast(UpdateBreakfastRequest request);

        List<string> GetBreakfasts();

    }
}
