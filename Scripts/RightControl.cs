using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightControl : MonoBehaviour
{
    public void RFlip()
    {
        if (Input.GetKey("right"))
            GetComponent<HingeJoint2D>().useMotor = true;
        else
            GetComponent<HingeJoint2D>().useMotor = false;
    }
    // Update is called once per frame
    void Update()
    {
        RFlip();
    }
}
