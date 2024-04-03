using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lockmouse : MonoBehaviour
{
    public GameObject plr;
    public bool enableded;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (enableded == false) // check if the mouse lock is disabled
            {
                Cursor.lockState = CursorLockMode.Locked;
                plr.GetComponent<Camera>().cameraLocked = true;
                plr.GetComponent<Movement>().cameraLocked = true;
                enableded = true;
            }
            else if (enableded == true) // check if its enabled otherwise
            {
                Cursor.lockState = CursorLockMode.None;
                plr.GetComponent<Camera>().cameraLocked = false;
                plr.GetComponent<Movement>().cameraLocked = false;
                enableded = false;
            }
        }
    }

}
