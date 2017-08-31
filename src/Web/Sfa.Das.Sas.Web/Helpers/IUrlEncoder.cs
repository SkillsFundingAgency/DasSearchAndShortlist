﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Sfa.Das.Sas.Web.Helpers
{
    public interface IUrlEncoder
    {
        string EncodeTextForUri(string providerNameToProcess);
    }

    public class UrlEncoder : IUrlEncoder
    {
        public string EncodeTextForUri(string providerNameToProcess)
        {
            var lowerCaseAndApostrophesAndHyphensRemoved = Regex.Replace(providerNameToProcess.ToLower(),"['-]", string.Empty);
              var splitBySpacesAndOtherChars = Regex.Split(lowerCaseAndApostrophesAndHyphensRemoved, @"[\s(),.]+");
            var rebuildExcludingNoContent = string.Join(
                "-",
                splitBySpacesAndOtherChars.Except(new List<string> { string.Empty })
            );

            var processHyphenPattern = ProcessInitialsHyphenPattern(rebuildExcludingNoContent);

            var ampersandAndPlusReplaced = Regex.Replace(processHyphenPattern, "[&+]", "and");
            return Regex.Escape(ampersandAndPlusReplaced);
     }

        private string ProcessInitialsHyphenPattern(string stringToProcess)
        {
            const string InitialsHyphenPattern = @"[a-z0-9]{1}-[a-z0-9]{1}-";
            var match = Regex.Match(stringToProcess, InitialsHyphenPattern);
            while (match.Length > 0)
            {
                var originalPattern = match.Value;
                var replacementPattern = originalPattern.Substring(0, 1) + originalPattern.Substring(2, 2);
                stringToProcess = stringToProcess.Replace(originalPattern, replacementPattern);
                match = Regex.Match(stringToProcess, InitialsHyphenPattern);
            }
            return stringToProcess;
        }
    }
}