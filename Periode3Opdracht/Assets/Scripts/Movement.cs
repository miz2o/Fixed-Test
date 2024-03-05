using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    public float speed;
    public float sens;
    public GameObject empty;
    public quaternion rotateTo;
    public float rotateSpeed;
    public float jP;
    public bool isgrounded;
    public bool cameraLocked;


    // Update is called once per frame
    void Update()
    {
        
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        if (cameraLocked == false)
        {

            if (vert > 0)
            {
                ////transform.eulerAngles = new Vector3(transform.rotation.x, empty.transform.eulerAngles.y, transform.rotation.x);
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y, transform.rotation.x), rotateSpeed * Time.deltaTime);
                transform.position += transform.forward * vert * speed * Time.deltaTime;


            }
            if (vert < 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y + 180f, transform.rotation.x), rotateSpeed * Time.deltaTime);
                transform.position += transform.forward * -vert * speed * Time.deltaTime;


            }
            if (hor > 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y + 90f, transform.rotation.x), rotateSpeed * Time.deltaTime);
                transform.position += transform.forward * hor * speed * Time.deltaTime;

            }
            if (hor < 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y + -90f, transform.rotation.x), rotateSpeed * Time.deltaTime);
                transform.position += transform.forward * -hor * speed * Time.deltaTime;

            }

        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y, transform.rotation.x), rotateSpeed * Time.deltaTime);
            transform.position += transform.forward * vert * speed * Time.deltaTime;

        }






        if (Input.GetButtonDown("Jump") && isgrounded == true)
            {
                isgrounded = false;

                print("jump");
                transform.GetComponent<Rigidbody>().AddForce(transform.up * jP, ForceMode.Impulse);

            }
            else if (Input.GetButtonUp("Jump"))
            {
                isgrounded = false;
            }






        ///// transform.position += transform.forward * vert * speed * Time.deltaTime; /// move the players character foward so it moves the same way the player is facing
        /// transform.position += transform.forward * hor * speed * Time.deltaTime;
        //// transform.position += transform.right * hor * speed * Time.deltaTime;

        empty.transform.position = new Vector3(transform.position.x, transform.position.y + 1.49f, transform.position.z);

    



    }
    void OnCollisionStay()
    {
        print("colliisinostay");
        isgrounded = true;
    }
}
