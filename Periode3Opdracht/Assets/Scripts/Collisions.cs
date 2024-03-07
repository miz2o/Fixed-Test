using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public float raycastsize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit1;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit1, 1))
        {
            if (hit1.transform.tag != "Floor")
            {
                Debug.Log("Did Hit");
            }

        }
    }
}
