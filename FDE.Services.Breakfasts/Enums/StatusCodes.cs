namespace FDE.Services.Breakfasts.Enums
{
    public enum StatusCodes
    {
        //2000's are success status code
        //4000's are fail status code

        AddBreakfastSuccess = 2201,
        AddBreakfastFail = 4201,

        UpdateBreakfastSuccess = 2202,
        UpdateBreakfastFail = 4202,

        DeleteBreakfastSuccess = 2203,
        DeleteBreakfastFail = 4203,

        GetBreakfastByIdSuccess = 2204,
        GetBreakfastByIdFail = 4204,

    }
}
