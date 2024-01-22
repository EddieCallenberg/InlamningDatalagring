using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Presentation.Enteties;

public class BossDropsEntity
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [ForeignKey(nameof(ItemId))]
    public int ItemId { get; set; }

    [Required]
    [ForeignKey(nameof(BossId))]
    public int BossId { get; set;}

    public virtual ItemEntity Item { get; set;} = null!;
    public virtual BossEntity Boss { get; set; } = null!;
}
