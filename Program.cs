public class Activity12
{
    public static void Main()
    {
        int wordCount = 0;
        int length = 0;
        string str = System.IO.File.ReadAllText("Input.txt.txt");

        while (length <= str.Length - 1)
        {
           
            if ((str[length] == '.' || str[length] == ' ' || str[length] == '\t' || str[length] == '!' || str[length] == ',' || str[length] == '?' || str[length] == '\n') && (str[length - 1] == 't' || str[length - 1] == 'e'))
            {
                wordCount++;
            }


            length++;
        }

        Console.Write("There are {0} words ending in t or e", wordCount);
    }
}
