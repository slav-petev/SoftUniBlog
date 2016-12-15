﻿namespace SoftUniBlog.classes
{
    public class Utils
    {
        public static string cutText(string text, int maxLength = 100)
        {
            if(text == null || text.Length <= maxLength)
            {
                return text;
            }
            var shortText = text.Substring(0, maxLength) + "...";
            return shortText;
            
        }
    }
}