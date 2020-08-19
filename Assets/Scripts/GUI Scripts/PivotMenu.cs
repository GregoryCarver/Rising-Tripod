using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotMenu : MonoBehaviour {

    private bool continueClicked;
    
    //Start the coroutine to slide menu off screen.
    public void PivotMenuOnClick()
    {
        StartCoroutine(RotateMe(Vector3.up * 90, .5f));
    }

    //The numerator used to edit the rotation of the menu, to slide it off screen.
    IEnumerator RotateMe(Vector3 byAngles, float inTime)
    {
        var fromAngle = transform.rotation;
        var toAngle = Quaternion.Euler(transform.eulerAngles + byAngles);
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            transform.rotation = Quaternion.Lerp(fromAngle, toAngle, t);
            yield return null;
        }
    }
}
