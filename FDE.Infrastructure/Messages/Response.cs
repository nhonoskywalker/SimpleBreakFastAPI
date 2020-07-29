using System.Collections.Generic;

namespace FDE.Infrastructure.Messages
{
    public class Response
    {
        private string message;

        public Response()
        {
            this.Errors = new List<string>();
            this.StatusCode = 1000;
            this.IsSuccessful = true;
        }

        public bool IsSuccessful { get; set; }

        public ICollection<string> Errors { get; set; }

        public string Message
        {
            get
            {
                return this.message ?? string.Join(string.Empty, this.Errors);
            }

            set
            {
                this.message = value;
            }
        }

        public int StatusCode { get; set; }

        public void SetError(int statusCode)
        {
            this.StatusCode = statusCode;
            this.IsSuccessful = false;
        }
    }
}
