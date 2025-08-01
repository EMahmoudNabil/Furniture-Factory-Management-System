using System.ComponentModel.DataAnnotations;

namespace Api_Task_Techtroll.co.Application.DTOs
{
    public class SubcomponentDto
    {
        public int Id { get; set; }
        public int ComponentId { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Material { get; set; } = string.Empty;
        public string? Notes { get; set; }

        public int Count { get; set; }
        public int TotalQuantity { get; set; }

        public decimal DetailLength { get; set; }
        public decimal DetailWidth { get; set; }
        public decimal DetailThickness { get; set; }

        public decimal CuttingLength { get; set; }
        public decimal CuttingWidth { get; set; }
        public decimal CuttingThickness { get; set; }

        public decimal FinalLength { get; set; }
        public decimal FinalWidth { get; set; }
        public decimal FinalThickness { get; set; }

        public string? VeneerInner { get; set; }
        public string? VeneerOuter { get; set; }
    }


    public class CreateSubcomponentDto
    {
        [Required]
        public int ComponentId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string Material { get; set; } = string.Empty;

        public string? Notes { get; set; }

        [Range(1, int.MaxValue)]
        public int Count { get; set; }

        public int TotalQuantity { get; set; }

        public float DetailLength { get; set; }
        public float DetailWidth { get; set; }
        public float DetailThickness { get; set; }

        public float CuttingLength { get; set; }
        public float CuttingWidth { get; set; }
        public float CuttingThickness { get; set; }

        public float FinalLength { get; set; }
        public float FinalWidth { get; set; }
        public float FinalThickness { get; set; }


        public string? VeneerInner { get; set; }
        public string? VeneerOuter { get; set; }
    }

    public class UpdateSubcomponentDto : CreateSubcomponentDto
    {
        [Required]
        public int Id { get; set; }
    }
}
