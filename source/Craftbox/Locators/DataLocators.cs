using Craftbox.Data;
using Craftbox.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craftbox.Locators;

/// <summary>
/// Return single desciptors based on passed parameters.
/// Only locates the containers, further processing is required for files within containers.
/// </summary>
public static class DataLocators
{
    /// <summary>
    /// Get the path of a character binder with the passed Character ID
    /// postfix can be used to switch between _l and _h
    /// </summary>
    public static ResourceDescriptor GetCharacterBinder(string chrId, string postfix = "")
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource is DataSource.DES)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"chr\{chrId}\{chrId}{postfix}.chrbnd.dcx");
        }
        else if (DataCore.DataSource is DataSource.DS1)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"chr\{chrId}{postfix}.chrbnd");
        }
        else if (DataCore.DataSource is DataSource.DS2 or DataSource.DS2S)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"model\chr\{chrId}{postfix}.bnd");
        }
        else
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"chr\{chrId}{postfix}.chrbnd.dcx");
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a character animation binder with the passed Character ID
    /// postfix can be used to switch between _l and _h
    /// </summary>
    public static ResourceDescriptor GetCharacterAnimationBinder(string chrId, string postfix = "")
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource is DataSource.DES)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"chr\{chrId}\{chrId}{postfix}.anibnd.dcx");
        }
        else if (DataCore.DataSource is DataSource.DS1)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"chr\{chrId}{postfix}.anibnd");
        }
        else if (DataCore.DataSource is DataSource.DS2 or DataSource.DS2S)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"model\chr\{chrId}{postfix}.bnd");
        }
        else
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"chr\{chrId}{postfix}.anibnd.dcx");
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a character behavior binder with the passed Character ID
    /// postfix can be used to switch between _l and _h
    /// </summary>
    public static ResourceDescriptor GetCharacterBehaviorBinder(string chrId, string postfix = "")
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource 
            is DataSource.DES 
            or DataSource.DS1 
            or DataSource.DS2 
            or DataSource.DS2S
            or DataSource.AC6)
        {
            desciptor.Path = ""; // Not used for these games.
        }
        else
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"chr\{chrId}{postfix}.behbnd.dcx");
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a character texture binder with the passed Character ID
    /// postfix can be used to switch between _l and _h
    /// </summary>
    public static ResourceDescriptor GetCharacterTextureBinder(string chrId, string postfix = "")
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource
            is DataSource.DES
            or DataSource.DS1
            or DataSource.DS2
            or DataSource.DS2S)
        {
            desciptor.Path = ""; // Not used for these games.
        }
        else
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"chr\{chrId}{postfix}.texbnd.dcx");
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a asset geometry binder with the passed Asset ID
    /// </summary>
    public static ResourceDescriptor GetAssetGeomBinder(string asset)
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource
            is DataSource.DES
            or DataSource.DS1
            or DataSource.DS2
            or DataSource.DS2S
            or DataSource.DS3
            or DataSource.BB
            or DataSource.SDT)
        {
            desciptor.Path = ""; // Not used for these games.
        }
        else if (DataCore.DataSource is DataSource.ER)
        {
            if (asset.Length >= 6)
            {
                desciptor.Path = LocatorUtils.GetOverridenFilePath(
                    $@"asset\aeg\{asset.Substring(0, 6)}\{asset}.geombnd.dcx");
            }
        }
        else if (DataCore.DataSource is DataSource.AC6)
        {
            if (asset.Length >= 6)
            {
                desciptor.Path = LocatorUtils.GetOverridenFilePath(
                    $@"asset\environment\geometry\{asset}.geombnd.dcx");
            }
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a asset collision binder with the passed Asset ID
    /// postfix can be used to switch between _l and _h
    /// </summary>
    public static ResourceDescriptor GetAssetCollisionBinder(string asset, string postfix = "")
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource
            is DataSource.DES
            or DataSource.DS1
            or DataSource.DS2
            or DataSource.DS2S
            or DataSource.DS3
            or DataSource.BB
            or DataSource.SDT)
        {
            desciptor.Path = ""; // Not used for these games.
        }
        else if (DataCore.DataSource is DataSource.ER)
        {
            if (asset.Length >= 6)
            {
                desciptor.Path = LocatorUtils.GetOverridenFilePath(
                    $@"asset\aeg\{asset.Substring(0, 6)}\{asset}.geombnd.dcx");
            }
        }
        else if (DataCore.DataSource is DataSource.AC6)
        {
            if (asset.Length >= 6)
            {
                desciptor.Path = LocatorUtils.GetOverridenFilePath(
                    $@"asset\aeg\{asset.Substring(0, 6)}\{asset}_{postfix}.geomhkxbnd.dcx");
            }
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a part binder with the passed Part ID
    /// postfix can be used to switch between _l and _h
    /// </summary>
    public static ResourceDescriptor GetPartBinder(string partId, string postfix = "")
    {
        ResourceDescriptor desciptor = new();

        desciptor.Path = LocatorUtils.GetOverridenFilePath(
            $@"parts\{partId}{postfix}.partsbnd.dcx");

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a part TPF binder with the passed Part ID
    /// postfix can be used to switch between _l and _h
    /// </summary>
    public static ResourceDescriptor GetPartTpf(string part, string postfix = "")
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource is DataSource.AC6)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath($@"parts\{part}{postfix}.tpf.dcx");
        }
        else
        {
            desciptor.Path = ""; // Not used for other games.
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a MSB file with the passed Map ID
    /// </summary>
    public static ResourceDescriptor GetMapMsb(string mapid)
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource is DataSource.DES or DataSource.DS1 or DataSource.DS1R)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath(
                $@"\map\MapStudio\{mapid}.msb");
        }
        else if (DataCore.DataSource is DataSource.DS2 or DataSource.DS2S)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath(
                $@"map\{mapid}\{mapid}.msb");
        }
        // BB chalice maps
        else if (DataCore.DataSource is DataSource.BB && mapid.StartsWith("m29"))
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath(
                $@"\map\MapStudio\{mapid.Substring(0, 9)}_00\{mapid}.msb.dcx");
        }
        else
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath(
                $@"\map\MapStudio\{mapid}.msb.dcx");
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a BTL file with the passed Map ID
    /// </summary>
    public static ResourceDescriptor GetMapBtl(string mapid, string btlId)
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource 
            is DataSource.BB 
            or DataSource.DS3 
            or DataSource.SDT)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath(
                $@"map\{mapid}\{btlId}.btl.dcx");
        }
        else if(DataCore.DataSource is DataSource.ER or DataSource.AC6)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath(
                $@"map\{mapid[..3]}\{mapid}");
        }
        else if (DataCore.DataSource is DataSource.DS2 or DataSource.DS2S)
        {
            desciptor.Path = ""; // Use GetMapGi
        }
        else
        {
            desciptor.Path = ""; // Not used in these games
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }

    /// <summary>
    /// Get the path of a GI file with the passed Map ID
    /// Unpacked with BXF to get BTL files.
    /// DS2 only.
    /// Postfix: model or model_lq
    /// </summary>
    public static ResourceDescriptor GetMapGi(string mapid, string postfix = "model")
    {
        ResourceDescriptor desciptor = new();

        if (DataCore.DataSource is DataSource.DS2 or DataSource.DS2S)
        {
            desciptor.Path = LocatorUtils.GetOverridenFilePath(
                $@"{postfix}\map\g{mapid[1..]}.gibhd");
        }
        else
        {
            desciptor.Path = "";
        }

        desciptor.Name = Path.GetFileName(desciptor.Path);

        return desciptor;
    }
}
