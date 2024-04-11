using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{

    // Function to save the game
    public void SaveGame()
    {

        // Save player position
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);



        // Save PlayerPrefs to disk
        PlayerPrefs.Save();
    }

    // Function to load the game
    public void LoadGame()
    {

        // Load player position
        float playerX = PlayerPrefs.GetFloat("PlayerX");
        float playerY = PlayerPrefs.GetFloat("PlayerY");
        float playerZ = PlayerPrefs.GetFloat("PlayerZ");
        transform.position = new Vector3(playerX, playerY, playerZ);

    }
}
