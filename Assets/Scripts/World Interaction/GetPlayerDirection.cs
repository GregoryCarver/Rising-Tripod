using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerDirection : MonoBehaviour
{
    public Vector2 lastDirection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            lastDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
    }
}
