namespace Thered_HW
{
    class Program
    {
        static void Main()
        {
            string Str = "x w x y x w";
            int x = 0, w = 0, y = 0;
            for (int i = 0; i < Str.Length; i++) 
            { if (Str[i] == 'x') { x++; } else if (Str[i] == 'w') { w++; } else if (Str[i] == 'y') { y++; } } // I could also use here Str.Contains() == true
            Console.WriteLine($"X: {x}\nY: {y}\nW: {w}");
        }
    }
}
