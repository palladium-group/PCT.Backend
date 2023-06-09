﻿using PCT.Backend.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCT.Backend.Entities
{
    [Table("mst_carrier")]
    public class Carrier : Entity
    {
        public string? Name { get; set; }
        public Guid Category { get; set; }
        public Guid Unit { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; }
    }
}
