using System;
using System.Collections.Generic;
using System.Text;

namespace FDE.Infrastructure.Messages.Breakfast
{
    public class UpdateBreakfastRequest
    {
        public int Id { get; set; }

        public string Value { get; set; }
    }
}
