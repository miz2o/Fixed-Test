using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject cam;
    public Vector2 camRot = Vector2.zero;
    public float sens;
    public GameObject empty;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            camRot.y += Input.GetAxis("Mouse X");
            camRot.x += -Input.GetAxis("Mouse Y");
            cam.transform.eulerAngles = (Vector2)camRot * sens; /// Rotate the camera from world space * by camera sensitivity
        }

        if (transform.rotation.x > 30)
        {
            transform.eulerAngles = new Vector3(30, transform.rotation.y, transform.rotation.z);
        }
        else if (transform.rotation.x < -30)
        {
            transform.eulerAngles = new Vector3(-30, transform.rotation.y, transform.rotation.z);
        }

    }
}
