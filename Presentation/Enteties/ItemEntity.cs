using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Enteties;

public class ItemEntity
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string ItemName { get; set; } = null!;

    [Required]
    [StringLength(200)]
    public string ItemDescription { get; set; } = null!;

    public virtual ICollection<InventoryEntity> InventoryEntities { get; set; } = null!;
    public virtual ICollection<BossDropsEntity> BossDropsEntities { get; set; } = null!;
}
