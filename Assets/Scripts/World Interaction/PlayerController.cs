using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public int walkSpeed;
    public bool busy;

	// Use this for initialization
	void Start ()
    {
        busy = false;
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        rigidBody.velocity = new Vector2(movement.x * walkSpeed, movement.y * walkSpeed);

        if(Input.GetKeyDown("space") && !busy)
        {
            if (gameObject.GetComponent<ClosestInteractionable>().closestInteractionable != null)
            {
                //busy = true;

                if (gameObject.GetComponent<ClosestInteractionable>().closestInteractionable.GetComponent<Interactionable>())
                {
                    gameObject.GetComponent<ClosestInteractionable>().closestInteractionable.GetComponent<Interactionable>().InterAction();
                }
            }
        }
    }
}
