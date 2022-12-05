using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis2Z : MonoBehaviour
{


    public void RotateAxis2Z(float targetRotationValue, float smooth)
    {

        // Rotate the cube by converting the angles into a quaternion.
       Quaternion target = Quaternion.Euler(0, 0, targetRotationValue);
        // Dampen towards the target rotation
        transform.localRotation = Quaternion.Slerp(transform.rotation, target, smooth);
      

    }
}
