using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class AnimLayeringScript : MonoBehaviour {
    public Animator anim;
    public Text textW;
    private float x, y = 0.0f;
    private float weight = 0.0f;

	void Update () {
        x = (Input.GetAxis("Horizontal"));
        y = (Input.GetAxis("Vertical"));

        anim.SetFloat("X", x);
        anim.SetFloat("Y", y);

        if (Input.GetButton("L1"))
        {
            weight -= 0.01f;
            if (weight <= 0)
                weight = 0.0f;
        }

        if (Input.GetButton("R1"))
        {
            weight += 0.01f;
            if (weight >= 1)
                weight = 1.0f;
        }

        textW.text = ("Animaton Weight : " + weight.ToString("F2"));

        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetLayerWeight(1, weight);
            anim.Play("attack_01", 1);
        }
    }
}
