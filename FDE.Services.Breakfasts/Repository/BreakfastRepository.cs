using System.Collections.Generic;

namespace FDE.Services.Breakfasts.Repository
{
    public class BreakfastRepository: IBreakfastRepository
    {
        private List<string> breakfasts = new List<string> { "Bread", "Hot Choco", "Coffee", "Sausage", "Hotdog", "Egg" };

        public BreakfastRepository()
        {

        }

        public string AddBreakfast(string value)
        {
            this.breakfasts.Add(value);

            var result = this.breakfasts[breakfasts.Count - 1];

            return result;
        }

        public string DeleteBreakfast(int id)
        {
            var result = this.breakfasts[id];

            this.breakfasts.RemoveAt(id);

            return result;
        }

        public string GetBreakfastById(int id)
        {
            var result = this.breakfasts[id];

            return result;
        }

        public List<string> GetBreaskfasts()
        {
            return new List<string>(this.breakfasts);
        }

        public string UpdateBreakfast(int id, string value)
        {
            this.breakfasts[id] = value;

            var result = this.breakfasts[id];

            return result;
        }
    }
}
