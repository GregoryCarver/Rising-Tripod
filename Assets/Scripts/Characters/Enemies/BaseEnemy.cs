using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : BaseCharacter
{
    public int Level { get; set; }

    public int MaxHp { get; set; }
    public int CurrHp { get; set; }
    public int MaxMp { get; set; }
    public int CurrMp { get; set; }

    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Defense { get; set; }
    public int Will { get; set; }
    public int Speed { get; set; }
    public int Agility { get; set; }

   BaseEnemy(string name, int level, int maxHp, int maxMp, int strength, int intelligence, int defense, int will, int speed, int agility) : base(name)
    {
        Level = level;
        MaxHp = maxHp;
        MaxMp = maxMp;
        CurrHp = maxHp;
        CurrMp = maxMp;
        Strength = strength;
        Intelligence = intelligence;
        Defense = defense;
        Will = will;
        Speed = speed;
        Agility = agility;
    }
}
