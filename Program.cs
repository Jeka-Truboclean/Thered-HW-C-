namespace Thered_HW
{
    class Program
    {
        static void Main()
        {
            string Str = "ojfbhojhfbduohbu";
            for (int i = 0; i < Str.Length; i++) 
            { 
                int count = Str.Length - Str.Replace(Str[i].ToString(), "").Length;
                Console.WriteLine($"Symb {Str[i]} - {count} times.");
                Str = Str.Replace(Str[i].ToString(), "");
                i--;
            }
        }
    }
}
