using System.Collections.Generic;

namespace ClothingStore.Option
{
    public class Size : IOption
    {
        private string name = OptionType.Size.ToString();

        private List<Property> options = new List<Property>
        {
            new Property { Description ="", Value = 39},
            new Property { Description ="", Value = 40}
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
