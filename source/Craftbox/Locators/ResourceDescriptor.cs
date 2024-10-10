using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftbox.Locators;

public class ResourceDescriptor
{
    public string Name { get; set; }    
    public string Path { get; set; }

    public ResourceDescriptor() { }

    public ResourceDescriptor(string name, string path)
    {
        Name = name;
        Path = path;
    }
}
