using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entites;

public class Photo: BaseEntity<int>
{
    public string ImageName { get; set; }
    public int ProudectId { get; set; }
    public virtual Proudect Proudect { get; set; }
}
