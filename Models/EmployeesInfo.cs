using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class EmployeesInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Division { get; set; }
        public byte Active { get; set; }
    }
}
