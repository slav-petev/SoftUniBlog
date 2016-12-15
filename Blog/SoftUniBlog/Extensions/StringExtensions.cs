using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftUniBlog.Extensions
{
    public static class StringExtensions
    {
        public static string TrimTextToLength(this string text, 
            int maxLength = 100)
        {
            if (string.IsNullOrWhiteSpace(text) ||
                text.Length <= maxLength) return text;

            return string.Concat(
                text.Substring(0, maxLength),
                "...");
        }
    }
}