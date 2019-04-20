using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Option
{
    public class Color : IOption
    {
        private string name = OptionType.Color.ToString();

        private List<Property> options = new List<Property>
        {
            new Property { Description ="", Value = "Blue"},
            new Property { Description ="", Value = "Red"}
        };

        string IOption.Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        List<Property> IOption.Options
        {
            get
            {
                return this.options;
            }
            set
            {
                this.options = value;
            }
        }
    }
}
