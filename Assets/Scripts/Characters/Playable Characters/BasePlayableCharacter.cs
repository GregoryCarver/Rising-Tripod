using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Things to do: -Load characters method?, -Decide whether potentials should be an enum or not. This would constrain them to 0-10, 
//               -Setup current hp and mp so that it can't be higher than max or lower than 0, -Decide what level characters start on,


//Notes: 1) Stat potentials should be from 0 to 10 in character creation. With 0 being worst and 10 being the best.

public class BasePlayableCharacter : BaseCharacter
{
    //Used to determine the max a stat can reach at max level, not the max of the current level.
    private const int statMax = 255;
    private const int hpMax = 9999;
    private const int mpMax = 999;

    //Stats that all playable characters have.
    //Potentials determine the amount gained in a level up. They are whole numbers from 0 to 10.
    public int CurrLevel { get; set; }

    private int _maxHp;
    public int MaxHp
    {
        get { return _maxHp; }
        set { if (value >= hpMax) _maxHp = hpMax; else _maxHp = value; }
    }
    public int MaxHpPotential { get; set; }
    public int CurrHp { get; set; }

    private int _maxMp;
    public int MaxMp
    {
        get { return _maxMp; }
        set { if (value >= mpMax) _maxMp = mpMax; else _maxMp = value; }
    }
    public int MaxMpPotential { get; set; }
    public int CurrMp { get; set; }

    public int CurrExp { get; set; }
    public int ExpToNextLevel { get; set; }

    private int _strength;
    public int Strength
    {
        get { return _strength; }
        set { if (value >= statMax) _strength = statMax; else _strength = value; }
    }
    public int StrengthPotential { get; set; }

    private int _intelligence;
    public int Intelligence
    {
        get { return _intelligence; }
        set { if (value >= statMax) _intelligence = statMax; else _intelligence = value; }
    }
    public int IntelligencePotential { get; set; }

    private int _defense;
    public int Defense
    {
        get { return _defense; }
        set { if (value >= statMax) _defense = statMax; else _defense = value; }
    }
    public int DefensePotential { get; set; }

    private int _will;
    public int Will
    {
        get { return _will; }
        set { if (value >= statMax) _will = statMax; else _will = value; }
    }
    public int WillPotential { get; set; }

    private int _speed;
    public int Speed
    {
        get { return _speed; }
        set { if (value >= statMax) _speed = statMax; else _speed = value; }
    }
    public int SpeedPotential { get; set; }

    private int _agility;
    public int Agility
    {
        get { return _agility; }
        set { if (value >= statMax) _agility = statMax; else _agility = value; }
    }
    public int AgilityPotential { get; set; }

    //Equipped equipment. Using the keys to make the slots. For example, Weapon, HeadGear, Armor, to ensure only those
    //types are equipped to that slot. 
    public Dictionary<EquipmentTypes, EquippableItem> EquippedEquipment;

    //The totals of stats and mods that get used in battle.
    public int Attack
    {
        get { return Strength + EquipmentStatTotal(StatType.Strength); }
    }
    public int MagAttack
    {
        get { return Intelligence + EquipmentStatTotal(StatType.Intelligence); }
    }
    public int Armor
    {
        get { return Defense + EquipmentStatTotal(StatType.Defense); }
    }
    public int MagArmor
    {
        get { return Will + EquipmentStatTotal(StatType.Will); }
    }
    public int TotalSpeed
    {
        get { return Speed + EquipmentStatTotal(StatType.Speed); }
    }
    public int TotalAgility
    {
        get { return Agility + EquipmentStatTotal(StatType.Agility); }
    }

    public BasePlayableCharacter(string name, int strengthPotential, int intelligencePotential, int defensePotential,
                                 int willPotential, int speedPotential, int agilityPotential) : base(name)
    {
        CurrLevel = 0;
        CurrExp = 1;
        ExpToNextLevel = 1;

        StrengthPotential = strengthPotential;
        IntelligencePotential = intelligencePotential;
        DefensePotential = defensePotential;
        WillPotential = willPotential;
        SpeedPotential = speedPotential;
        AgilityPotential = agilityPotential;

        LevelUpManager.LevelUp(this);

        CurrHp = MaxHp;
        CurrMp = MaxMp;
    }

    //Used to calculate the stat total for a particular stat of all equipped equipment.
    private int EquipmentStatTotal(StatType statType)
    {
        int total = 0;

        foreach(KeyValuePair<EquipmentTypes, EquippableItem> equipment in EquippedEquipment)
        {
            total = equipment.Value.Stats.Where(stat => stat.ModType == statType).Sum(stat => stat.ModAmount);
        }

        return total;
    }
}
