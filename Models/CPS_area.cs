using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleReact.Models
{
    public class CPS_area
    {
        [Key]
        public string Id { get; set; }

        public string Deskripsi { get; set; }
    }
}
