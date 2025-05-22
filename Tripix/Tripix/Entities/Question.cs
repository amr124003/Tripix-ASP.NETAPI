using System.ComponentModel.DataAnnotations.Schema;

namespace Tripix.Entities
{
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string question { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Response { get; set; }
    }
}
