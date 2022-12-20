using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftControl : MonoBehaviour
{
   public void Flip()
   {
    if (Input.GetKey("left"))
        GetComponent<HingeJoint2D>().useMotor = true;
    else
        GetComponent<HingeJoint2D>().useMotor = false;
   }

    // Update is called once per frame
    void Update()
    {
        Flip();
    }
}
