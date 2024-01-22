using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Enteties;

public class BossEntity
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string BossName { get; set; } = null!;

    public virtual ICollection<BossDropsEntity> BossDropsEntities { get; set; } = null!;
}