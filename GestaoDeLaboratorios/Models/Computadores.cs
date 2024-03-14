using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.ComponentModel.DataAnnotations;

namespace GestaoDeLaboratorios.Models
{
    public class Computadores
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string marca { get; set; }

        [Required]
        public string processador { get; set; }

        [Required]
        public string placaMae { get; set; }

        [Required]
        public int memoria { get; set; }

        [Required]
        public string hd { get; set; }

        public string numeroPratrimonio { get; set; }

        public string dataCompra { get; set; }

    }
}
