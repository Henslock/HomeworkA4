using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class AnimLayeringScript : MonoBehaviour {

    /*
    Animation Layering Assignment - Takes controller axis input and maps that to parameters that affect the character's animation in Unity's Animator interface.
    You can use X to swing (our additive animation) and R1/L1 to increase the weight of the animation.

    Josh Bellyk - 100526009
    Owen Meier  - 100538643    
    */

    public Animator anim;
    public Text textW;
    private float x, y = 0.0f;
    private float weight = 0.0f;

	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetLayerWeight(1, weight);
            anim.Play("attack_01", 1);
        }

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

        anim.SetLayerWeight(1, weight);
        textW.text = ("Animaton Weight : " + weight.ToString("F2"));
    }
}
