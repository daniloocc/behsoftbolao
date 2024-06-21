using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behsoft.Utils;

public static class AvatarUtils
{
    public static string GetAvatarPorNome(string nome)
    {
        var nomeCompleto = string.Join("+", nome.Split(' '));
        return $"https://ui-avatars.com/api/?background=random&name={nomeCompleto}";
    }
}
