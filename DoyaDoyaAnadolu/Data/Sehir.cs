using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoyaDoyaAnadolu.Data
{
    public class Sehir
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)] //otomatik ıd nin artmasını engeller
        public int Id { get; set; }
        [MaxLength(50)]

        public string SehirAd { get; set; } = "";
        public int Nufus { get; set; }
        public int BolgeId { get; set; }

        public Bolge Bolge { get; set; } = null!; //null ı affeden operatöre şimdilik null sonra veritabanı dolacak o zaman kadar uyarı verme
    }
}
