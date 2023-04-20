using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopAPI.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string NazwaProduktu { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public DateTime DataEdycji { get; set; }
        public string OpisArtykulu { get; set; }
        public int Cena { get; set; }
    }
}