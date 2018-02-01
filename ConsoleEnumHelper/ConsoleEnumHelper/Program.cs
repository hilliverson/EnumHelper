using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEnumHelper
{
    public enum LanguageEnum
    {
        [Description("en-US")]
        English = 1,
        [Description("ja-JP")]
        Japanese = 2
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "en-US";
            if (EnumHelper.TryGetValueFromDescription<LanguageEnum>("en-US")) 
                Console.WriteLine(name);

            Console.WriteLine(LanguageEnum.English.GetDescription());
            Console.ReadLine();
        }
    }
}
