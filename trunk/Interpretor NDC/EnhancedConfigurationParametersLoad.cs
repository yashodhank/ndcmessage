using System;
using System.Collections.Generic;
using System.Text;

namespace Interpretor_NDC
{
    class EnhancedConfigurationParametersLoad : CustomisationDataCommands
    {
        public string LUNO2 = "";
        public string[] OptionNumber = null;
        public string[] OptionCode = null;

        public EnhancedConfigurationParametersLoad(string str)
            : base(str)
        {
            Name = "Configuration Parameters Load";

            int sep1 = Utils.StrIndexOf('∟', str, 3);
            int sep2 = Utils.StrIndexOf('∟', str, 4);

            
            
        }
    }
}