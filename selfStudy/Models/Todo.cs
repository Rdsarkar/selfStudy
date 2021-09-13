using System;
using System.Collections.Generic;

#nullable disable

namespace selfStudy
{
    public partial class Todo
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsCompleted { get; set; }
    }
}
