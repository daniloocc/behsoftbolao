using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils;

public static class AvatarUtils
{
    public static string GetAvatarPorNome(string nome)
    {
        var nomes = nome.Split(' ');
        return $"https://ui-avatars.com/api/?background=random&name={nomes[0]}{(!string.IsNullOrEmpty(nomes[1]) ? "+"+nomes[1]:"")}";
    }
}
