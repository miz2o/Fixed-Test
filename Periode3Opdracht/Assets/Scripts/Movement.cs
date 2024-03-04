using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    public float speed;
    public float sens;
    public GameObject empty;






    // Update is called once per frame
    void Update()
    {

        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");


        transform.position += transform.forward * vert * speed * Time.deltaTime; /// move the players character foward so it moves the same way the player is facing
        transform.position += transform.right * hor * speed * Time.deltaTime;

        empty.transform.position = new Vector3(transform.position.x, transform.position.y + 1.49f, transform.position.z);

        if (hor > 0 || vert > 0)
        {
            transform.eulerAngles = empty.transform.eulerAngles;
        }


    }
}
