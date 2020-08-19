using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleArea : MonoBehaviour
{
    public List<ScriptableObject> enemyGroups;
    public byte battleRate = 5;
    public float battleCount = 0;
    public Vector2 playerLastPos;

    private void OnTriggerEnter2D(Collider2D other)
    {
        GlobalVariables.currentEnemyGroup = enemyGroups;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (GlobalVariables.playerRigidbody.position != playerLastPos)
        {
            battleCount += battleRate * Mathf.Sqrt(Mathf.Pow(Input.GetAxis("Horizontal"), 2) + Mathf.Pow(Input.GetAxis("Vertical"), 2));

            if (battleCount > Random.Range(1100, 2000))
            {
                Debug.Log("BATTLE!");
                battleCount = 0;
            }
        }

        playerLastPos = GlobalVariables.playerRigidbody.position;
    }
}
