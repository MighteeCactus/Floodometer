using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FloodometerDesktop
{
    class SkypeParser
    {
        public static string PATTERN = @"\[(\d\d\.\d\d\.\d\d\d\d) (\d\d:\d\d:\d\d)";

        public void parseText(string textToParse) {
            Regex rgx = new Regex(PATTERN, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(textToParse);
            
            foreach(string post in matches) {
                                
            }
        }
    }
}
