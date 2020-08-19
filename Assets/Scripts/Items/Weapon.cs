using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Things to add: -check other equipment types for consistency in what equipment contains, -add abilities to certain weapons

//Specific type of weapon(maybe used to determine which characters can equip).
public enum WeaponTypes
{
    Sword,
    Knuckles,
    Staff,
    Gun
}

public class Weapon : EquippableItem
{
    //Info that is commonly provided on only weapons.
    public WeaponTypes WeaponType { get; set; }

    //Constructor.
    public Weapon(string name, string description, int id, WeaponTypes weaponType, List<StatMod> stats) : 
                  base(name, description, id, stats)
    {
        EquipmentType = EquipmentTypes.Weapon;
        WeaponType = weaponType;
    }

    Weapon ExampleSword = new Weapon("Excalibur", "Wowwweee", 0, WeaponTypes.Sword,
                              new List<StatMod> { new StatMod { ModType = StatType.Strength, ModAmount = 11 } });
    
}
