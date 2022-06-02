using System.Text.RegularExpressions;

class test
{

    public test()
    {
    }
    public static void Main(String[] args)
    {

        var test = new test();

        test.checker("#CD5e56");

    }


    void checker(String test)
    {
        string pattern = "[A-Za-z]";
        Regex rg = new Regex(pattern);
        Console.WriteLine(test);
        MatchCollection list = rg.Matches(test);
        List<string> l = new List<string>();
        foreach (Match item in list)
        {

            l.Add(item.Value);
            Console.Write(item.Value);
        }
        Console.WriteLine();
        test.Substring(1, 1);

        string actual = "";
        foreach (var item in l)
        {
            actual += item;
        }
        Console.WriteLine(actual + "  Actual here ");
        l.Sort();
        Console.WriteLine();
        string contrast = "";
        foreach (var item in l)
        {
            contrast += item;
        }

        Console.WriteLine(contrast + "\n");
        Console.WriteLine(contrast == actual);
        if (test.Length == 7)
        {
            if (test[0] == '#' && contrast == actual)
            {
                Console.WriteLine("IsValidHexCode");
            }
            else { Console.WriteLine("It is not a Valid HexCode"); }
        }

        else { Console.WriteLine("It is not a Valid HexCode"); }



    }






}