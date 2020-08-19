using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticSpriteSorter : MonoBehaviour
{
    private SpriteRenderer[] staticRenderers;

    // Use this for initialization
    void Start()
    {
        staticRenderers = FindObjectsOfType<SpriteRenderer>();

        foreach(SpriteRenderer renderer in staticRenderers)
        {
            renderer.sortingOrder = (int)((renderer.transform.position.y) * -100);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
