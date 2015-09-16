using System;
using System.Collections.Generic;
using System.Linq;

namespace _GZFramework.Demo.Library.Config.DBConnBuilder
{
    public interface IDB
    {
        string ProviderName { get; set; }
        string GetConnectionStr();
    }
}
