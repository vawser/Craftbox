using Craftbox.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftbox.Data;

public class DataCore
{
    public static DataSource DataSource { get; set; }

    /// <summary>
    /// This is the path to the root game install directory
    /// </summary>
    public static string RootPath { get; set; }

    /// <summary>
    /// This is the path to the project folder (where you want files to output)
    /// </summary>
    public static string ProjectPath { get; set; }

    /// <summary>
    /// Setups the data handling for Craftbox
    /// </summary>
    public DataCore()
    {
        // This is the game that we are working on.
        // This is checked by the locators to determine how to search for resources.
        DataSource = DataSource.ER;

        // EXAMPLE: change this to suit your needs
        // This is the directory path to the game install of the game you are working on.
        RootPath = "F:\\SteamLibrary\\steamapps\\common\\ELDEN RING\\Game";

        // EXAMPLE: change this to suit your needs
        // This is the directory path to the folder you want to output files to.
        ProjectPath = "C:\\Users\\benja\\Modding\\Elden Ring\\Projects\\Craftbox-Test";
    }
}
