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
                starshardcollected = true;
                SceneManager.LoadScene("DesertTemple_Inside");
            }

        }
        if (Otherobject.gameObject.tag == "starShard")
        {

            SceneManager.LoadScene("Mainscene");
        }


        if (Otherobject.gameObject.tag == "snowCollider")
        {
            if (!peridot)
            {
                peridot = true;
                SceneManager.LoadScene("SnowTemple");
            }

        }


        if (Otherobject.gameObject.tag == "forestCollider")
        {
            if (!spaceRift)
            {
                spaceRift = true;
                SceneManager.LoadScene("ForestTemple");
            }

        }

        if (Otherobject.gameObject.tag == "Finish")
        {
            if (starshardcollected && peridot && spaceRift)
            {
                SceneManager.LoadScene("winScene");
            }

        }
    }
}
