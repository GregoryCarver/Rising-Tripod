using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemyScriptableObject : ScriptableObject
{
    public string enemyName;
    public int level;

    public int maxHp;
    public int currHp;
    public int maxMp;
    public int currMp;

    public int strength;
    public int intelligence;
    public int defense;
    public int will;
    public int speed;
    public int agility;
}
