using System;
class Program {
    static void Main() {
        string[] parts = Console.ReadLine().Split(' ');
        int max = int.Parse(parts[0]);
        for (int i = 1; i < parts.Length; i++) {
            int num = int.Parse(parts[i]);
            if (num > max) max = num;
        }
        Console.WriteLine("Max: " + max);
    }
}
