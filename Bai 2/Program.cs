using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Task a: xuất ra bình phương của các số lớn hơn 4
        List<int> nums = new List<int>() { 1, 3, 4, 5, 8, 9 };
        var squaredNumbers = nums.Where(n => n > 4).Select(n => n * n);

        Console.WriteLine("bình phương của các số lớn hơn 4:");
        foreach (var num in squaredNumbers)
        {
            Console.WriteLine(num);
        }

        // Task b: xuất ra màn hình lần lượt số lần xuất hiện của từng chữ
        string str = "chao mung den voi binh nguyen vo tan";
        var characterCounts = str.GroupBy(c => c)
                                 .Select(g => new { Character = g.Key, Count = g.Count() });

        Console.WriteLine("\nCharacter counts:");
        foreach (var item in characterCounts)
        {
            Console.WriteLine($"Character: {item.Character}, Count: {item.Count}");
        }

        // Task c: xuất ra màn hình những chuỗi được viết hoa toàn bộ
        string str2 = "CHAO mung DEN Voi binh nguyen vo tan";
        var uppercaseWords = str2.Split(' ')
                                 .Where(word => word.All(char.IsUpper));

        Console.WriteLine("\nUppercase words:");
        foreach (var word in uppercaseWords)
        {
            Console.WriteLine(word);
        }
    }
}