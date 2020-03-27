using System.Collections.Generic;

namespace BakeryTreat.Models
{
  public class Treat
  {
    public Treat()
    {
        this.Flavors = new HashSet<TreatFlavor>();
    }

    public int TreatId { get; set; }
    public string TreatType { get; set; }
    public virtual ICollection<TreatFlavor> Flavors { get; set; }
  }
}