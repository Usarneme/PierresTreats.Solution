using System;

namespace PierresTreats.Models
{
  public class FlavorTreat
  {
    public FlavorTreat()
    {
      FlavorTreatId = Guid.NewGuid().ToString();
    }
    public string FlavorTreatId { get; set; }
    public string FlavorId { get; set; }
    public virtual Flavor Flavor { get; set; }
    public string TreatId { get; set; }
    public virtual Treat Treat { get; set; }
  }
}
