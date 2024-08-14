internal class Program
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>() { "1-Bülent Ersoy", "2-Ajda Pekkan", "3-Ebru Gündeş", "4-Hadise", "5-Hande Yener", "6-Tarkan", "7-Funda Arar", "8-Demet Akalın" };
        Console.WriteLine("**Davetliler**");

        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
       

    }
}