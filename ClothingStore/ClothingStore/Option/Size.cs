using System.Collections.Generic;

namespace ClothingStore.Option
{
    public class Size : IOption
    {
        private string name = OptionType.Size.ToString();

        private List<Property> options;

        private string type = "int";

        public string Name
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

        public List<Property> Options
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

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
    }
}
