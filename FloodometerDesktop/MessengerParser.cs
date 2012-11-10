using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FloodometerDesktop
{
    class MessengerParser
    {
        public static string SKYPE_PATTERN = @"\[(\d\d\.\d\d\.\d\d\d\d) ([\d]?\d:[\d]?\d:[\d]?\d).*\] (.+?): (.*)";
        public static string QIP9095_PATTERN = @"\S+ \(([\d]?\d:[\d]?\d:[\d]?\d) ([\d]?\d\/[\d]?\d\/\d\d\d\d)\)\n";

        public MatchCollection parseText(string textToParse, string pattern) {
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            return rgx.Matches(textToParse);
        }
    }
}
