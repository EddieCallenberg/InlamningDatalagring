using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentation.Enteties;

public class InventoryEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(CharacterEntity))]
    public int CharacterId { get; set; }

    [Required]
    [ForeignKey(nameof(ItemEntity))]
    public int ItemId { get; set; }

    public virtual CharacterEntity Character { get; set; } = null!;
    public virtual ItemEntity Item { get; set;} = null!;
}
