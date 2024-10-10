using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftbox.Enums;

/// <summary>
/// This determines what game root is used to draw data from.
/// Akin to project type in Smithbox/DSMS
/// </summary>
public enum DataSource
{
    None = 0,
    DES = 1,    // Demon's Souls
    DS1 = 2,    // Dark Souls: Prepare to Die
    DS1R = 3,   // Dark Souls: Remastered
    DS2 = 4,    // Dark Souls II
    DS2S = 5,   // Dark Souls II: Scholar of the First Sin
    DS3 = 6,    // Dark Souls III
    BB = 7,     // Bloodborne
    SDT = 8,    // Sekiro: Shadows Die Twice
    ER = 9,     // Elden Ring
    AC6 = 10,   // Armored Core VI: Fires of Rubicon
}