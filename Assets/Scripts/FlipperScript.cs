using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{
    public float restPos = 0f;
    public float deployedAngle = 50f;
    public float hitStrength = 1000f;
    public float flipperDamper = 150f;

    public KeyCode actionInput;
    private HingeJoint joint;

    void Start()
    {
        joint = GetComponent<HingeJoint>();
        joint.useSpring = true;

    }

    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Input.GetKey(actionInput))
        {
            spring.targetPosition = deployedAngle;
        }
        else
        {
            spring.targetPosition = restPos;
        }
        joint.spring = spring;
        joint.useLimits = true;
    }
}
