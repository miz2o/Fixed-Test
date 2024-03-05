using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lockmouse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

}
