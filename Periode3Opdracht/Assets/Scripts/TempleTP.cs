using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TempleTP : MonoBehaviour
{
    public GameObject plr;


    void OnCollisionEnter(Collision Otherobject)
    {
        print("col");
        if (Otherobject.gameObject.tag == "desertCollider")
        {
           SceneManager.LoadScene("DesertTemple_Inside");
        }
    }
}
