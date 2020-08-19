using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Group", menuName = "ScriptableObjects/Enemy Group", order = 2)]
public class EnemyGroupScriptableObject : ScriptableObject
{
    public Sprite fieldSprite;

    public List<EnemyScriptableObject> enemyGroup;
}
