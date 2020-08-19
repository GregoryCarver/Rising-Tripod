using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Things to add: -

//Specific type of armor(maybe used to determine which characters can equip).
public enum ArmorTypes
{
    //Might make armor universal.
}

public class Armor : EquippableItem
{
    //Info that is shared between armors.
    public ArmorTypes ArmorType { get; set; }

    //Constructor.
    public Armor(string name, string description, int id, ArmorTypes armorType, List<StatMod> stats) :
                  base(name, description, id, stats)
    {
        EquipmentType = EquipmentTypes.Armor;
        ArmorType = armorType;
    }
}
