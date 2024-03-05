using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject cam;
    public Vector2 camRot = Vector2.zero;
    public float sens;
    public GameObject empty;

    public bool cameraLocked;

    public float t;

    // Update is called once per frame
    void Update()
    {
        if (cameraLocked == false)
        {


            if (Input.GetMouseButton(1))
            {
                camRot.y += Input.GetAxis("Mouse X");
                if (camRot.x <= 8 || camRot.x >= 8)
                {
                    camRot.x += -Input.GetAxis("Mouse Y");
                    cam.transform.eulerAngles = (Vector2)camRot * sens;
                }


                /// Rotate the camera from world space * by camera sensitivity
            }


        }
        else
        {
            camRot.y += Input.GetAxis("Mouse X");
            camRot.x += -Input.GetAxis("Mouse Y");
            cam.transform.eulerAngles = (Vector2)camRot * sens;
        }
        if (camRot.x > 8)
        {
            print("above");
            camRot.x = 8f;
        }
        else if (camRot.x < -11)
        {
            print("below");
            camRot.x = -11f;

        }
    }
}
