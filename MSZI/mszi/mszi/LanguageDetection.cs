namespace mszi
{
    public class LanguageDetection
    {
       public int first { get; set; }
       public int last { get; set; }

        static int Detection(int word)
        {
            if ((int) 'a' <= word && word <= (int) 'z')
            {
                return (int)'a';
            }
            else if ((int) 'а' <= word && word <= (int) 'я')
            {
                return (int) 'а';
            }
            else
            {
                return int.MinValue;
            }
        }
    }
}
