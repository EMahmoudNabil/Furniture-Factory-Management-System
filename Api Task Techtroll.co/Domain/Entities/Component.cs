using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api_Task_Techtroll.co.Domain.Entities
{
    public class Component
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "اسم المكون مطلوب")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "الكمية يجب أن تكون أكبر من 0")]
        public int Quantity { get; set; }

        //  Navigation
        public Product Product { get; set; } = default!;
        public ICollection<Subcomponent> Subcomponents { get; set; } = new List<Subcomponent>();
    }
}
