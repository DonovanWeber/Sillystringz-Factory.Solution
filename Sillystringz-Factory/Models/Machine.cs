using System;
using System.Collections.Generic;

namespace SillystringzFactory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();

    }
    public int MachineId { get ; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}