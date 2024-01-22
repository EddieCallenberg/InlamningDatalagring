using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Enteties;

public class CharacterEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(12)]
    public string CharacterName { get; set; } = null!;

    [Required]
    [Range(1, 60)]
    public int CharacterLevel { get; set; }

    [Required]
    [StringLength(20)]
    public string CharacterClass { get; set; } = null!;

    public virtual ICollection<InventoryEntity> InventoryEntities { get; set; } = null!;
}
