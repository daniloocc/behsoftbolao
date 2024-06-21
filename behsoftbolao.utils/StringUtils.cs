using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behsoft.Utils;

public static class StringUtils
{
    private static readonly string ALFABETO = "ABCDEFGHIJKLMNOPQRSTUVXWYZ0123456789";
    private static readonly string NUMBERS = "0123456789";
    public static string RandomAlfaString(int n)
    {
        Random random = new();
        return new string(Enumerable.Repeat((ALFABETO), n).Select( s => s[random.Next(0, s.Length)]).ToArray());
    }

    public static string RandomString(int n)
    {
        Random random = new();
        return new string(Enumerable.Repeat((ALFABETO+NUMBERS), n).Select(s => s[random.Next(0, s.Length)]).ToArray());
    }

}
