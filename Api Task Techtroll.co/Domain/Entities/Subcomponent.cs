using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Api_Task_Techtroll.co.Domain.Entities
{
    public class Subcomponent
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Component))]
        public int ComponentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Material { get; set; } = string.Empty;

        public string? Notes { get; set; }

        [Range(1, int.MaxValue)]
        public int Count { get; set; }

        //  TotalQuantity 
        [NotMapped]
        public int TotalQuantity => Count * (Component?.Quantity ?? 1);

        // Detail Size
        [Range(0, 1000)]
        public float DetailLength { get; set; }
        [Range(0, 1000)]
        public float DetailWidth { get; set; }
        [Range(0, 1000)]
        public float DetailThickness { get; set; }

        // Cutting Size
        [Range(0, 1000)]
        public float CuttingLength { get; set; }
        [Range(0, 1000)]
        public float CuttingWidth { get; set; }
        [Range(0, 1000)]
        public float CuttingThickness { get; set; }

        // Final Size
        [Range(0, 1000)]
        public float FinalLength { get; set; }
        [Range(0, 1000)]
        public float FinalWidth { get; set; }
        [Range(0, 1000)]
        public float FinalThickness { get; set; }

        [MaxLength(50)]
        public string InnerVeneer { get; set; } = string.Empty;

        [MaxLength(50)]
        public string OuterVeneer { get; set; } = string.Empty;

        //  Navigation
        public Component Component { get; set; } = default!;
    }
}
