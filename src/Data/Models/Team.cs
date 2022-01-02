using System.ComponentModel.DataAnnotations;

namespace ControlCenterServer.Data.Models;

public class Team
{
    public Guid TeamId { get; set; }

    [Required]
    [MaxLength(60)]
    public string Name { get; set; }

    // Relations
    public virtual ICollection<UserProfile> Users { get; set; }
}