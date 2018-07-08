using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcCore.Models
{
    public class Query
    {
        [Required, Range(1, 100)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
