using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entites;

public class Proudect:BaseEntity<int>
{
    public string Name { get; set; }=string.Empty;
    public string Description { get; set; }=string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
