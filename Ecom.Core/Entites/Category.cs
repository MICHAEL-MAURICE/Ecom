using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entites;

public class Category : BaseEntity<int> 
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ICollection<Proudect> Proudects { get; set; } = new HashSet<Proudect>();
}
