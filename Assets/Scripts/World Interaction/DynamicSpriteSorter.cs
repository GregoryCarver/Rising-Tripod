using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicSpriteSorter : MonoBehaviour

{
    SpriteRenderer renderer;
    // Use this for initialization
    void Start ()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        renderer.sortingOrder = (int)((renderer.transform.position.y) * -100);
	}
}
