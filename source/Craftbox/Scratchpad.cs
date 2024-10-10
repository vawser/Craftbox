using Craftbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftbox;

/// <summary>
/// A scratchpad for making quick scripts that execute when Craftbox is run.
/// </summary>
public class Scratchpad
{
    public DataCore DataCore;

    public Scratchpad() 
    {
        DataCore = new DataCore();
    }

    /// <summary>
    /// Write scripts here
    /// </summary>
    public void Execute()
    {

    }
}
