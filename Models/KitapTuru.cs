using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebProjectMVC.Models
{
    // Karşılığı veritabanında Tablo olan classlara Entity diyoruz
    // Code First yaklaşımıyla yapıyoruz
    public class KitapTuru
    {
        [Key]    // primary key    
        public int Id { get; set; }

        [Required(ErrorMessage = "Kitap Tür Adı boş bırakılamaz!")]  // not null
        [MaxLength(25)]
        [DisplayName("Kitap Türü Adı")]
        public string Ad { get; set; }
    }
}
