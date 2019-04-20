using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Option
{
    public interface IOption
    {
        string Name { get; set; }

        List<Property> Options { get; set; }
    }
}
