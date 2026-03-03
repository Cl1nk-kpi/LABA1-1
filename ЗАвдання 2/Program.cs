using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        List<Dictionary<string, string>> inputData = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { { "V", "S001" } },
            new Dictionary<string, string> { { "V", "S002" } },
            new() { { "VI", "S001" } },
            new() { { "VI", "S005" } },
            new Dictionary<string, string> { { "VII", "S005" } },
            new() { { "V", "S009" } },
            new Dictionary<string, string> { { "VIII", "S007" } }
        };

        HashSet<string> uniqueValues = new HashSet<string>();

        foreach (var dict in inputData)
        {
            foreach (var value in dict.Values)
            {
                uniqueValues.Add(value);
            }
        }

        Console.WriteLine($"UniqueValues: {{'{string.Join("', '", uniqueValues)}'}}");

        Dictionary<string, HashSet<string>> resultDictionary = new Dictionary<string, HashSet<string>>
        {
            { "UniqueValues", uniqueValues }
        };

        JsonSerializerOptions options = new JsonSerializerOptions {WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(resultDictionary, options);         //

        string filePath = "result.json";
        File.WriteAllText(filePath, jsonString);

        Console.WriteLine($"\nРезультат успішно збережено у файл: {Path.GetFullPath(filePath)}");
    }
}
