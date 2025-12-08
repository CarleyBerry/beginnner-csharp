using System;
class Program {
    static void Main() {
        string s = Console.ReadLine().ToLower();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        string r = new string(arr);
        if (s == r) Console.WriteLine("Palindrome");
        else Console.WriteLine("Not a palindrome");
    }
}
