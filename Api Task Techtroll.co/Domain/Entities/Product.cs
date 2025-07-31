using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Api_Task_Techtroll.co.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "اسم المنتج مطلوب")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "السعر يجب أن يكون رقمًا موجبًا")]
        public decimal Price { get; set; }

        //  Navigation
        public ICollection<Component> Components { get; set; } = new List<Component>();
    }
}
