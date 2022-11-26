using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float cameraSpeed ;
    float xRotation;
    public Transform player;

    private void Update()   
    {
        if (Input.GetMouseButton(1))    //Mouse Movement after click right button of the mouse
        {
            MouseMovement();
        }
    }
    #region MouseMovement
    void MouseMovement()
    {
        float x = Input.GetAxis("Mouse X") * cameraSpeed * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * cameraSpeed * Time.deltaTime;
        xRotation -= y;
        xRotation = Mathf.Clamp(xRotation, -60f, 60f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * x);
    }
    #endregion
}
