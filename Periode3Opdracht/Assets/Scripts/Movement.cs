using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
////transform.eulerAngles = new Vector3(transform.rotation.x, empty.transform.eulerAngles.y, transform.rotation.x);
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
    public float raycastsize;
    public Vector3 rayto;
    public float camheight;


    // Update is called once per frame
    void Update()
    {



        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        if (cameraLocked == false)
        {
            if (vert > 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y, transform.rotation.x), rotateSpeed * Time.deltaTime);
                Move(vert);

            }



            if (vert < 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y + 180f, transform.rotation.x), rotateSpeed * Time.deltaTime);
                transform.position += transform.forward * -vert * speed * Time.deltaTime;
            }

            if (hor > 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y + 90f, transform.rotation.x), rotateSpeed * Time.deltaTime);
                Move(hor);

            }
            if (hor < 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y + -90f, transform.rotation.x), rotateSpeed * Time.deltaTime);
                Move(-hor);

            }

        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, empty.transform.eulerAngles.y, transform.rotation.x), rotateSpeed * Time.deltaTime);
            Move(vert);

        }



        if (Input.GetButtonDown("Jump") && isgrounded == true) //jummp
        {
            isgrounded = false;

            print("jump");
            transform.GetComponent<Rigidbody>().AddForce(transform.up * jP, ForceMode.Impulse);

        }



        empty.transform.position = new Vector3(transform.position.x, transform.position.y + camheight, transform.position.z);





    }

    void OnCollisionStay()
    {
        isgrounded = true;
    }

    void Move(float v)
    {
        RaycastHit hit;
        if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, raycastsize))
        {
            transform.position += transform.forward * v * speed * Time.deltaTime;
        }
       
    }
}
