using System.Collections.Generic;
using System.Linq;
using System;
using System.Web;

namespace SillystringzFactory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities {get; set; }
  }
}