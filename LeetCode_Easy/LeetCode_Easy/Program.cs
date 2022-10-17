// See https://aka.ms/new-console-template for more information

 

 int RomanToInt(string s)
{
    Dictionary<char, int> dict = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };


    char[] ch = s.ToCharArray();
    int result = 0;
    int intVal, nextIntValue;

    for (int i = 0; i < ch.Length; i++)
    {
        intVal = dict[ch[i]];

        if (i != ch.Length-1)
        {
            nextIntValue = dict[ch[i + 1]];

            if (nextIntValue>intVal)
            {
                intVal = nextIntValue - intVal;
                i += 1;
            }
        }
        result += intVal;
    }
    return result;
}

Console.WriteLine(RomanToInt("LVIII"));

Console.ReadLine();