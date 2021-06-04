using System;
using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      FlavorId = Guid.NewGuid().ToString();
      FlavorTreats = new HashSet<FlavorTreat>();
    }
    public string FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreats { get; set; }
  }
}
