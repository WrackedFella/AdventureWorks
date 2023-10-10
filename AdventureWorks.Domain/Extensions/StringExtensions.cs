﻿using System.Text;

namespace AdventureWorks.Domain.Extensions
{
    public static class StringExtensions
    {
        public static string AddSpaces(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return "";
            }

            var newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (var i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) && text[i - 1] != ' ')
                    newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }
    }
}
