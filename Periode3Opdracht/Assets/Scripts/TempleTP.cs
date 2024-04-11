using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TempleTP : MonoBehaviour
{
    public GameObject plr;
    public bool starshardcollected;
    public bool spaceRift;
    public bool peridot;


    void OnCollisionEnter(Collision Otherobject)
    {
       
        if (Otherobject.gameObject.tag == "desertCollider")
        {
            if (!starshardcollected)
            {
                SceneManager.LoadScene("DesertTemple_Inside");
            }
           
        }
        if (Otherobject.gameObject.tag == "starShard")
        {
            starshardcollected = true;
            SceneManager.LoadScene("Mainscene");
        }
    }
}
