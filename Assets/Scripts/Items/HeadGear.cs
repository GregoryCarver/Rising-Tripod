using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Things to do: -decide if different types of headgear, -check other equipment types, so they are consistent with what info they have(like models and stuff)

//Specific headgear type(maybe used to determine which players can equip).
public enum HeadGearTypes
{
    Helmet,
    Bandana,
}

public class HeadGear : EquippableItem
{
    //Info that is by only headgear.
    public HeadGearTypes HeadGearType { get; set; }

    //Constructor.
    public HeadGear(string name, string description, int id, HeadGearTypes headGearType, List<StatMod> stats) : 
                    base(name, description, id, stats)
    {
        EquipmentType = EquipmentTypes.HeadGear;
        HeadGearType = headGearType;
    }
}
