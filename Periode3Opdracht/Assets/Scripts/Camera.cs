using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject cam;
    public Vector2 camRot = Vector2.zero; // set camera rotation to zero
    public float sens;
    public GameObject empty;

    public bool cameraLocked;

    public float t;

    // Update is called once per frame
    void Update()
    {
        if (cameraLocked == false) // do this is camera isnt locked
        {


            if (Input.GetMouseButton(1)) // if player right clicks
            {
                camRot.y += Input.GetAxis("Mouse X");
                /////if (camRot.x <= 8 || camRot.x >= 8) // 
                
                    camRot.x += -Input.GetAxis("Mouse Y");
                    cam.transform.eulerAngles = (Vector2)camRot * sens;
                


              
            }


        }
        else /// do this when camera is locked
        {
            camRot.y += Input.GetAxis("Mouse X");
            camRot.x += -Input.GetAxis("Mouse Y");
            cam.transform.eulerAngles = (Vector2)camRot * sens;
        }
        if (camRot.x > 8) // dont go further above
        {
            print("above");
            camRot.x = 8f;
        }
        else if (camRot.x < -11) // dont go further under
        {
            print("below");
            camRot.x = -11f;

        }
    }
}
