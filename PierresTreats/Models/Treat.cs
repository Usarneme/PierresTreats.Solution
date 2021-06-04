using System;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      TreatId = Guid.NewGuid().ToString();
      FlavorTreats = new HashSet<FlavorTreat>();
    }
    public string TreatId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreats { get; set; }
  }
}
