namespace T2Library
{
    public static class IntExtension
    {
        static readonly Dictionary<char, string> dict = new Dictionary<char, string>()
        {
            { '1', "Один"},
            { '2', "Два"},
            { '3', "Три"},
            { '4', "Четыре" },
            { '5', "Пять" },
            { '6', "Шесть"},
            { '7', "Семь"},
            { '8', "Восемь" },
            { '9', "Девять" },
            { '0', "Ноль"}
        };

        public static string IntToString(this int value)
        {
            var temp = value.ToString().ToCharArray();
            var result = "";
            foreach (var item in temp)
            {
                foreach (var numb in dict)
                {
                    if(item == numb.Key)
                    {
                        result += numb.Value;
                    }
                }
            }
            return result;
        }        
    }
}