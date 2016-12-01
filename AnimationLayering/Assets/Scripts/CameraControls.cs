using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {

    /*
    Animation Layering Assignment - Simple horizontal camera controls.

    Josh Bellyk - 100526009
    Owen Meier  - 100538643    
    */
    void Update ()
    {
        float angH = Input.GetAxis("AnalogHorizontal") * 3;

        if (angH >= 1.0f || angH <= -1.0f)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + angH, 0);
        }
    }
}
