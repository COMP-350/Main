using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpSpeed = 10f;
    public float forwardSpeed = 10;

    private Rigidbody2D body2d;
    private InputState inputState;

    void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
        inputState = GetComponent<InputState>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputState.standing)
        {
            if (inputState.actionButton)
            {
                //forwardSpeed = forwardSpeed * inputState.power;
               // jumpSpeed = jumpSpeed * inputState.power;
                body2d.velocity = new Vector2(forwardSpeed, jumpSpeed);
            }
        }
    }
}
