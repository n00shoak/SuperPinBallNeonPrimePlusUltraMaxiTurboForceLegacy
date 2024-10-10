using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlipperScript : MonoBehaviour
{
    public float restPos = 0f;
    public float deployedAngle = 50f;
    public float hitStrength = 1000f;
    public float flipperDamper = 150f;

    private HingeJoint joint;
    private float currentAngle;

    void Start()
    {
        joint = GetComponent<HingeJoint>();
        joint.useSpring = true;
    }

    public void Flip(InputAction.CallbackContext context)
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;
        if (context.started)
        {
            currentAngle = deployedAngle;
        }

        if(context.canceled == true)
        {
            currentAngle = restPos;
        }

        spring.targetPosition = currentAngle;
        joint.spring = spring;
        joint.useLimits = true;
    }
}
