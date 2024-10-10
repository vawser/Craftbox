using Craftbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftbox.Locators;

public static class LocatorUtils
{
    /// <summary>
    /// Get the game install path (based on the relative path), 
    /// or the project path if it exists.
    /// </summary>
    public static string GetOverridenFilePath(string relpath)
    {
        var rootPath = $@"{DataCore.RootPath}\{relpath}";
        var modPath = $@"{DataCore.ProjectPath}\{relpath}";

        if (File.Exists(modPath))
            return modPath;

        if (File.Exists($@"{rootPath}"))
            return rootPath;

        return null;
    }
}
