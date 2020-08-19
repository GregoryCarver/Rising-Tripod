using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Things to add: -Things to carry between scenes like Flags(see NPC's, haven't decided where to add). -maybe split global variables into their scene specifics

public static class GlobalVariables
{
    public static List<ScriptableObject> currentEnemyGroup;
    public static Rigidbody2D playerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
}
