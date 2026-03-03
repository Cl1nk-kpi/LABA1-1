using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> poemLines = new List<string>
        {
            "Важко вчитись в КПІ",
            "Бо багато лабок",
            "Й буду заробляти",
            "Буду дуже радий я",
            "І мати купу бабок!"  
        };

        poemLines.Sort((a, b) => a.Length.CompareTo(b.Length));

        Console.WriteLine("Рядки від меншого до більшого:");
        foreach (var line in poemLines)
        {
            Console.WriteLine($"[{line.Length}] {line}");
        }

        string allText = string.Join(" ", poemLines);
        char[] separators = { ' ', ',', '!' };

        List<string> wordsList = new List<string>(allText.Split(separators, StringSplitOptions.RemoveEmptyEntries));
        wordsList.Sort((wordA, wordB) => wordA.Length.CompareTo(wordB.Length));

        string longestWord = wordsList[wordsList.Count - 1];

        Console.WriteLine("\nНайдовше слово:");
        Console.WriteLine($"Слово: {longestWord} (Довжина: {longestWord.Length})");

    }
}


