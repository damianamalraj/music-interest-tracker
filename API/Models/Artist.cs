using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class Artist
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<User> Users { get; set; }
    public virtual ICollection<Song> Songs { get; set; }
  }
}