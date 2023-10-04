using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{

    private Animator animator;
    private InputState inputState;

    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
        inputState = GetComponent<InputState>();

    }

    // Update is called once per frame
    void Update()
    {

        var jumping = false;

        if (inputState.absVelX > 0)// && inputState.absVelY < inputState.standingThreshold)
            jumping = true;

        animator.SetBool("Jumping", jumping);
    }
}
