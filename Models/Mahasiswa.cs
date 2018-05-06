using System.ComponentModel.DataAnnotations;

namespace MahasiswaCrud.Models
{
    public class Mahasiswa 
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [StringLength(255)]
        public string Name {get; set;}

        public int Age {get; set;}
    }
}