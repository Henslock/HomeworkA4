using UnityEngine;
using System.Collections;

public class CameraControls : MonoBehaviour {

	void Update ()
    {
        float angH = Input.GetAxis("AnalogHorizontal") * 3;

        if (angH >= 1.0f || angH <= -1.0f)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + angH, 0);
        }
    }
}
