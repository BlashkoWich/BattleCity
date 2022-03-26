using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RotateScript : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Rotate(90);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            Rotate(-90);
        }
    }
    private void Rotate(float angleRotate)
    {
        float currentRotationZ = transform.rotation.eulerAngles.z;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, currentRotationZ + angleRotate);
    }
}
