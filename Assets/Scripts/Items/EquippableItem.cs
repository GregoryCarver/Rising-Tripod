using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Things to add: -variables for models and such??, 

//The differing types of equipment. Used to display in inventory and make sure only specific equipments art equipped to 
//the appropriate spots.
public enum EquipmentTypes
{
    Weapon,
    Armor,
    HeadGear
}

//Implemented this incase equipment needed to be separated further.
public class EquippableItem : BaseItem
{
    public EquipmentTypes EquipmentType { get; set; }
    //List of the stats the item modifies. Each stat is a StatMod with a mod type and mod amount. 
    //Use collection initializers when creating the list in the individual items.
    public List<StatMod> Stats { get; set; }

    //Constructor
    public EquippableItem(string name, string description, int id, List<StatMod> stats) : base(name, description, id)
    {
        Stats = stats;
    }
}
