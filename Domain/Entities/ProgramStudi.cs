using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProgramStudi : BaseEntities
    {
        [Key]
        public int ProgramStudiID { get; set; }
        public string? Kode { get; set; }
        public string? Nama { get; set; }
    }
}
