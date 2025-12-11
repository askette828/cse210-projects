public class Scripture
{
    static List<string> scripture_text = new List<string> { "Helaman 10:15 And it came to pass that when Nephi had declared unto them the word, behold, they did still harden their hearts and would not hearken unto his words; therefore they did revile against him, and did seek to lay their hands upon him that they might cast him into prison." };
    
    public static void Display()
    {
        foreach (var item in scripture_text)
        {
            Console.WriteLine(item);
        }
    }

    public static List<string> ConvertToStringArray()
    {
        List<string> words = new List<string>();
        foreach (var item in scripture_text)
        {
            words = item.Split(' ').ToList();
        }
        return words;
    }
}