using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Option
{
    public static class OptionUtility
    {
        public static List<IOption> GetOption(List<IOption> options)
        {
            List<IOption> opts = new List<IOption>();
            
            foreach (IOption opt in options)
            {
                string optLst = string.Empty;
                var newOpt = CreateNewOption(opt);
                newOpt.Options = new List<Property>();

                Console.WriteLine(string.Format("Please choose {0} by value", opt.Name));
                foreach (Property item in opt.Options)
                {
                    optLst += string.Format("Option Description: {0} _ Option Value:{1} \r\n", item.Description, item.Value);
                }

                Console.Write(optLst);
                var val = Console.ReadLine().ToString();
                var optChoose = opt.Options.SingleOrDefault(o => Comparer(opt.Type, val, o.Value));
                if (optChoose != null)
                {
                    
                    newOpt.Options.Add(optChoose);
                    opts.Add(newOpt);
                }
            }

            return opts;
        }

        public static string PrintOption(List<IOption> options)
        {
            string result = string.Empty;

            foreach (var opt in options)
            {
                result += string.Format("Option {0} \r\n", opt.Name);
                foreach (var item in opt.Options)
                {
                    result += string.Format("Option Description: {0} _ Option Value:{1} \r\n", item.Description, item.Value);
                }
            }

            return result;
        }

        private static IOption CreateNewOption(IOption opt)
        {
            if (opt.Name == OptionType.Color.ToString())
            {
                return new Color();
            }
            if (opt.Name == OptionType.Size.ToString())
            {
                return new Size();
            }

            return null;
        }

        private static bool Comparer(string type, object x, object y)
        {
            if (type == "int")
            {
                return int.Parse(x.ToString()) == int.Parse(y.ToString());
            }
            if (type == "string")
            {
                return x.ToString() == y.ToString();
            }

            return false;
        }


    }
}
