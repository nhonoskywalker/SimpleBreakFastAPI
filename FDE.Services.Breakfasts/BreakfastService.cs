using FDE.Infrastructure.Messages.Breakfast;
using FDE.Services.Breakfasts.Enums;
using FDE.Services.Breakfasts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FDE.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        private readonly IBreakfastRepository breakfastRepository;

        public BreakfastService(IBreakfastRepository breakfastRepository)
        {
            this.breakfastRepository = breakfastRepository;
        }

        public AddBreakfastResponse AddBreakfast(AddBreakfastRequest request)
        {
            var response = new AddBreakfastResponse();
            var breakfasts = this.breakfastRepository.GetBreaskfasts();

            //Check for duplicate entry
            if (breakfasts.FirstOrDefault(breakfast => breakfast.ToLower() == request.Name.ToLower()) != null)
            {
                response.IsSuccessful = false;
                response.StatusCode = (int)StatusCodes.AddBreakfastFail;
            }
            else
            {
                var _newBreakfast = this.breakfastRepository.AddBreakfast(request.Name);
                response.Data = _newBreakfast;
                response.IsSuccessful = true;
                response.StatusCode = (int)StatusCodes.AddBreakfastSuccess;
            }

            return response;
        }

        public DeleteBreakfastResponse DeleteBreakfast(DeleteBreakfastRequest request)
        {
            var response = new DeleteBreakfastResponse();
            var breakfasts = this.breakfastRepository.GetBreaskfasts();


            //Check if id exists
            if (request.Id < 0 || request.Id > breakfasts.Count)
            {
                response.IsSuccessful = false;
                response.StatusCode = (int)StatusCodes.DeleteBreakfastFail;
            }
            else
            {
                var _deletedBreakfast = this.breakfastRepository.DeleteBreakfast(request.Id);
                response.Data = _deletedBreakfast;
                response.StatusCode = (int)StatusCodes.DeleteBreakfastSuccess;
                response.IsSuccessful = true;

            }

            return response;
        }

        public GetBreakfastByIdResponse GetBreakfastById(GetBreakfastByIdRequest request)
        {
            var response = new GetBreakfastByIdResponse();
            var breakfasts = this.breakfastRepository.GetBreaskfasts();

            if (request.Id < 0 || request.Id > breakfasts.Count)
            {
                response.IsSuccessful = false;
                response.StatusCode = (int)StatusCodes.GetBreakfastByIdFail;
            }
            else
            {
                var _breakfast = this.breakfastRepository.GetBreakfastById(request.Id);
                response.Data = _breakfast;
                response.StatusCode = (int)StatusCodes.GetBreakfastByIdSuccess;
                response.IsSuccessful = true;

            }

            return response;
        }

        public List<string> GetBreakfasts()
        {
            var result = this.breakfastRepository.GetBreaskfasts();

            return result;
        }

        public UpdateBreakfastResponse UpdateBreakfast(UpdateBreakfastRequest request)
        {
            var response = new UpdateBreakfastResponse();
            var breakfasts = this.breakfastRepository.GetBreaskfasts();

            //Check if id exists
            if (request.Id < 0 || request.Id > breakfasts.Count)
            {
                response.IsSuccessful = false;
                response.StatusCode = (int)StatusCodes.UpdateBreakfastFail;
            }
            else
            {
                var _updatedBreakfast = this.breakfastRepository.UpdateBreakfast(request.Id, request.Value);

                response.Data = _updatedBreakfast;
                response.StatusCode = (int)StatusCodes.UpdateBreakfastSuccess;
                response.IsSuccessful = true;
            }

            return response;
        }
    }
}
