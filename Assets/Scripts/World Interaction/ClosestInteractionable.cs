using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosestInteractionable : MonoBehaviour
{
    public GameObject closestInteractionable;
    public Dictionary<string, GameObject> gameObjectsInRange;

	// Use this for initialization
	void Start ()
    {
        gameObjectsInRange = new Dictionary<string, GameObject>();
	}

    // Update is called once per frame
    void Update()
    {
        GetClosestInteractionable();
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject newObject = collider.gameObject;

        if (newObject.GetComponent<Interactionable>())
        {
            gameObjectsInRange.Add(newObject.name, newObject);
            GetClosestInteractionable();
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        GameObject objectExiting = collider.gameObject;

        gameObjectsInRange.Remove(objectExiting.name);

        if (gameObjectsInRange.Count == 0)
        {
            closestInteractionable = null;
        }
        else
        {
            GetClosestInteractionable();
        }
    }

    public void GetClosestInteractionable()
    {
        if (gameObjectsInRange.Count > 0)
        {
            foreach (KeyValuePair<string, GameObject> interactionableObject in gameObjectsInRange)
            {
                if (DotProduct(gameObject, interactionableObject.Value) > 0)
                {
                    if(closestInteractionable == null)
                    {
                        closestInteractionable = interactionableObject.Value;
                    }
                    else if (Distance(gameObject, interactionableObject.Value) < Distance(gameObject, closestInteractionable))
                    {
                        closestInteractionable = interactionableObject.Value;
                    }
                }
                else if (closestInteractionable == interactionableObject.Value)
                {
                    closestInteractionable = null;
                }
             
            }
        }
        else
        {
            closestInteractionable = null;
        }
    }

    private float DotProduct(GameObject objectOne, GameObject objectTwo)
    {
        float product;

        product = (objectOne.GetComponent<GetPlayerDirection>().lastDirection.x * 
                  (objectTwo.transform.position.x - objectOne.transform.position.x)) +
                  (objectOne.GetComponent<GetPlayerDirection>().lastDirection.y * 
                  (objectTwo.transform.position.y - objectOne.transform.position.y));

        return product;
    }

    private float Distance(GameObject objectOne, GameObject objectTwo)
    {
        float distance;

        distance = Mathf.Sqrt(Mathf.Pow((objectTwo.transform.position.x - objectOne.transform.position.x), 2) + 
                              Mathf.Pow((objectTwo.transform.position.y - objectOne.transform.position.y), 2));

        return distance;
    }
}
