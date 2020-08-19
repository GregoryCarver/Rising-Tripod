using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Types of stats, used on equipment and items. This way they can be queried by type.
public enum StatType
{
    Strength,
    Intelligence,
    Defense,
    Will,
    Speed,
    Agility
}

public struct StatMod
{
    public StatType ModType { get; set; }
    public int ModAmount { get; set; }

    public StatMod(StatType modType, int modAmount)
    {
        ModType = modType;
        ModAmount = modAmount;
    }

    void Start()
    {

    }
 }
