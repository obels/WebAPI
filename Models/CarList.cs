using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class CarList
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
