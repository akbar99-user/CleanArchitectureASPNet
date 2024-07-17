using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mahasiswa : BaseEntities
    {
        [Key]
        public int MahasiswaID { get; set; }
        public string Nama {  get; set; }
        public string JenisKelamin {  get; set; }
        public string Alamat {  get; set; }
        public string NoHP { get; set; }
        public string NIM { get; set; }
    }
}
