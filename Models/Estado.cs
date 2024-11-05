using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DPAV.Models
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}